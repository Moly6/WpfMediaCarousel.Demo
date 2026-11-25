# WpfMediaCarousel.Demo

English | [简体中文](README.zh-CN.md)

A small Windows WPF app showing how to use the [WpfMediaCarousel control](https://github.com/Moly6/WpfMediaCarousel).

## Clone and run

Install the .NET 10 SDK, then clone the repository:

```powershell
git clone https://github.com/Moly6/WpfMediaCarousel.Demo.git
cd WpfMediaCarousel.Demo
dotnet run --project src/WpfMediaCarousel.Demo/WpfMediaCarousel.Demo.csproj
```

The project installs the `WpfMediaCarousel` control from NuGet during restore. The carousel includes three local artwork slides and an online Big Buck Bunny video sample. The video slide requires an internet connection and is licensed by the Blender Foundation under [Creative Commons Attribution 3.0](https://bbb3d.renderfarming.net/download.html). The film is not redistributed in this repository.

## What it demonstrates

- `ObservableCollection<MediaItem>` as the `ItemsSource`.
- Per-image durations and `Stretch` settings.
- A per-item video placeholder and looping option.
- `IsAutoPlay`, navigation buttons, indicators, blur background, and overlay opacity.
- A NuGet `PackageReference` to `WpfMediaCarousel`.

## License

The application code and original image assets are MIT licensed; see [LICENSE](LICENSE). The linked film has the separate license described above.
