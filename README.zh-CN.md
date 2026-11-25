# WpfMediaCarousel.Demo

[English](README.md) | 简体中文

这是一个可运行的 WPF 示例，用来展示 [WpfMediaCarousel 控件](https://github.com/Moly6/WpfMediaCarousel) 的常见用法。

## 环境要求

- Windows。
- .NET 10 SDK。
- Git。

## 获取并运行

在终端执行：

```powershell
git clone https://github.com/Moly6/WpfMediaCarousel.Demo.git
cd WpfMediaCarousel.Demo
dotnet run --project src/WpfMediaCarousel.Demo/WpfMediaCarousel.Demo.csproj
```

也可以用 Visual Studio 打开 `WpfMediaCarousel.Demo.sln`，还原依赖后运行 `WpfMediaCarousel.Demo` 项目。

项目还原时会从 NuGet 下载 `WpfMediaCarousel` 控件包，无需克隆控件库仓库。

## 示例内容

- 使用 `ObservableCollection<MediaItem>` 作为轮播控件的 `ItemsSource`。
- 展示本地图片、图片显示时长、自动轮播与 `Stretch` 填充方式。
- 展示上一项/下一项按钮、位置指示器、模糊背景和遮罩透明度。
- 通过 NuGet `PackageReference` 引用 `WpfMediaCarousel` 控件库。
- 轮播图包含三张本地原创示例图片；最后一项从 Google 的公开视频样例地址播放 Big Buck Bunny，因此播放视频需要联网。该影片由 Blender Foundation 制作，采用 [Creative Commons Attribution 3.0](https://bbb3d.renderfarming.net/download.html) 许可。本仓库不重新分发影片文件。

本地示例图片会复制到构建输出目录的 `Assets` 文件夹。视频播放还取决于 Windows 对相应媒体格式的支持。

## 许可证

示例代码和原创图片采用 MIT License，详见 [LICENSE](LICENSE)。联网播放的影片采用上文所述的独立许可。
