# FindReferenceInScene

[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)
[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)](#)
[![NuGet](https://img.shields.io/badge/nuget-v1.0.0-blue)](#)

Component, reference search within the hierarchy of GameObject.

<!-- Badges: https://shields.io/ -->
<!-- Reference -->
<!-- https://kakakakakku.hatenablog.com/entry/2018/08/08/200903 -->

<!-- Code Quality: https://app.codacy.com/ -->
<!-- https://srz-zumix.blogspot.com/2018/07/cireview-codacy.html-->

<!-- OTHER LICENSE -->
<!-- BSD [![License](https://img.shields.io/badge/license-BSD--3%20clause-blue.svg)](LICENSE) -->
<!-- Apache2 [![License](https://img.shields.io/badge/license-Apache%202-blue.svg)](LICENSE) -->
<!-- GPL [![License](https://img.shields.io/badge/license-GPL-blue.svg)](LICENSE) -->

<!-- [![Coverity Scan](https://scan.coverity.com/projects/4884/badge.svg)](https://scan.coverity.com/projects/glfw-glfw) -->
<!-- [![chat](https://badges.gitter.im/LLGL-Project/LLGL.svg)]() -->

## ■ Documentation

* [Home](#boilerplate-unitypackage)
* [Documentation](#-documentation)
* [Introduction](#-introduction)
* [Build Status](#-build-status)
* [Install](#-directory-structure)
  * [from NuGet](#from-nuget)
  * [from Unity Package Manager](#from-unity-package-manager)
  * [from unity package](#from-unity-package)
* [Wiki](#-wiki)
  * [ScriptReference](#script-reference)
* [Setup](#-setup)
* [Dependencies](#-dependencies)
* [Directory Structure](#-directory-structure)
* [License](#-license)
* [Reference](#-reference)
* [Memo](#-memo)

## ■ Introduction

<!-- edit introduction. -->

## ■ Build Status

### *Platform Supports*

<!-- vertical layout -->

| Platform | Test | CI |
|----------|:--:|:-----:|
| Editor | [![Build Status](https://img.shields.io/badge/build-passing-brightgreen)](#) | N/A |

## ■ Install

### from NuGet

- nuget package manager.

### from Unity Package Manager

- `manifest.json`

```
{
    "com.aria.unity.xxx": "https://github.com/TK-Aria/skeleton.git#master" 
}
```

## from unity package

- [download this here Releases](https://github.com/TK-Aria/skeleton/releases)

 <img src="https://pngimage.net/wp-content/uploads/2018/06/unity-logo-white-png-5.png" height="20" /> drag and drop or double click on unity package file.

## ■ Wiki

- [ScriptReference](#)

## ■ Dependencies

The documentation is generated with Doxygen if CMake can find that tool.

## ■ License
※ [about License](https://qiita.com/tukiyo3/items/58b8b3f51e9dc8e96886)

- [MIT License](./LICENSE)

## ■ Reference


## ■ Memo

```
IAudioPlayer
AudioPlayer

object, IAudioPlayer 

AudioPlayer_BGM -> Play時の挙動を設定する
AudioPlayer_SoundFX -> 
AudioPlayer_Jingle


// 基本的にコンテキストのラッパー
SoundManager


AudioCtrlContext
{

mixer

playerTable 
AddPlayer
}

Flux
Dispatcher
Action
Store
View

ViewRouter

object, IViewController

ViewStacker
viewをStackする。勝手に色々する

scriptable build pipeline

GASで簡単決済サービス作成

drogonを試してみる

Unity ScriptTemplateの活用

UnityとSlackを連携

独自のUnityパッケージ管理システムの構築

unityのパッケージ管理が辛いという話
良いモジュールを作っても、
別プロジェクトに持って行くときは手動でコピーする
npmみたいにもっと手軽に管理したい

npmみたいなやついなかったけ？

Unity Package Manager (UPM) (内部でnpm)
まだまだ開発途中で 2020 beta (alpha)の現段階でもそんなに
2019.1くらいの頃から進歩が無いように見える。
特に、publicオンリーなことと
自作パッケージを依存対象に含めないというのが、致命的な為実用段階にはない。
社内ライブラリなどの規模が大きめで下位モジュールに対してモジュール依存がある場合は実用段階にはない。

安定するまで、自作するしかない

要件
自作パッケージ間で依存解決ができる
private, public問わない
出来れば upmが安定した際に、すぐ移動できる

候補
NuGet
npm

yarn
jem

NuGetを用いる
シンプルな仕様ゆえ使いやすい
これが一番簡単そうだった
サードパーティのパッケージ管理クライアントがある(ここが決めて)
これがない場合、コマンドインストールになるので、人や職種によってはハードルが高い

NuGetForUnity

AzureArtifact
内部でxmlパースしているので、v3APIを使用する

独自のパッケージリポジトリを作る際は他にも、MyGetなどがある

git hook 
ファイルパス
ファイル容量は気をつける.
ファイル内容

一番の問題点、設定されないこと
unity起動時に .git/hook以下に指定ファイルが存在するか確認する。
なければ、エラー文(ダイアログ)を出した後、editorを強制的に閉じる

ffmpeg 
audio stream 

docker x11 emulate (pyside)

unity windows wpf avalondock

unity audio 
unity native audio

unity native plugin (rust)

serializable dictionary

unity maya c++

unity ML(python tensolflow?)
```
