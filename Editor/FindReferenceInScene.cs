#if UNITY_EDITOR
using System;
using System.Reflection;
using UnityEngine;
using UnityEditor;


namespace FindReferenceInScene
{
	
	/// <summary>
	///  GameObjectのヒエラルキー参照検索.
	/// </summary>
	public class HierarchyObjectFinder
	{

		[MenuItem("GameObject/Find Reference In Scene (Instanced)", false, 20)]
		public static void FindReferenceInScene( )
		{
			HierarchyControl.FindReference(Selection.activeGameObject.GetInstanceID());
		}
		
	}

	/// <summary>
	///  Componentのヒエラルキー参照検索.
	/// </summary>
	public static class HierarchyComponentFinder
	{

		[MenuItem("CONTEXT/Component/Find References In Scene (Instanced)")]
		private static void FindReferencesInScene(MenuCommand command)
		{
			var targetComponent = command.context as Component;
			if (targetComponent == null)
			{
				return;
			}
			HierarchyControl.FindReference(targetComponent.GetInstanceID());
		}

	}

	/// <summary>
	///  ヒエラルキー制御を行います.
	/// </summary>
	public static class HierarchyControl
	{
		#region Const

		private const string hierarchyTypeName = "UnityEditor.SceneHierarchyWindow,UnityEditor";

		#endregion // Const End.

		#region Utils

		private static string MakeSearchFilter(int instanceId)
		{
			return string.Format("ref:{0}:", instanceId);
		}

		public static SearchableEditorWindow GetHierarchyFilter()
		{
			var sceneHierarchyWindowType = Type.GetType(hierarchyTypeName);
			return EditorWindow.GetWindow(sceneHierarchyWindowType) as SearchableEditorWindow;
		}

		public static void FindReference(int instanceId )
		{
			var hierarchyFilter = GetHierarchyFilter(); 
			Reflection.SetSearchFilter( hierarchyFilter, MakeSearchFilter(instanceId), SearchableEditorWindow.SearchMode.All);
			hierarchyFilter.Repaint();
		}

		#endregion // Utils End.

	}

	public static class Reflection
	{

		/// <summary>
		///  ヒエラルキー内にフィルター検索を掛けます.
		/// </summary>
		public static void SetSearchFilter(SearchableEditorWindow hierarchyFilter, string searchFilter, SearchableEditorWindow.SearchMode searchMode)
		{
			const string reflectionMethodName = "SetSearchFilter";

			var setSearchFilterMethod = hierarchyFilter.GetType().GetMethod(reflectionMethodName, BindingFlags.Instance | BindingFlags.NonPublic);

		#if UNITY_2018_2_3
			setSearchFilterMethod.Invoke(hierarchyFilter, new object[] { searchFilter, searchMode, false });
		#elif UNITY_2018_2_21
			setSearchFilterMethod.Invoke(hierarchyFilter, new object[] { searchFilter, searchMode, false, false });
		#elif UNITY_2019_1_14
			setSearchFilterMethod.Invoke(hierarchyFilter, new object[] { searchFilter, searchMode, false, false });
		#else // UNITY_2018_3
			setSearchFilterMethod.Invoke(hierarchyFilter, new object[] { searchFilter, searchMode });
		#endif // UNITY VERSION.

		}

	}

}

#endif // UNITY_EDITOR End.

