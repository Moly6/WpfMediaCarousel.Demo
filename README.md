# WpfMediaCarousel.Demo

A small Windows WPF app showing how to use the [WpfMediaCarousel control](https://github.com/Moly6/WpfMediaCarousel).

## Clone and run

Install the .NET 10 SDK, then clone this repository with its control-library submodule:

```powershell
git clone --recurse-submodules https://github.com/Moly6/WpfMediaCarousel.Demo.git
cd WpfMediaCarousel.Demo
dotnet run --project src/WpfMediaCarousel.Demo/WpfMediaCarousel.Demo.csproj
```

If you already cloned without submodules, initialize them with:

```powershell
git submodule update --init --recursive
```

The carousel starts with three locally included original artwork slides. The final slide streams the Big Buck Bunny sample from Google's public test-video bucket, so that slide requires an internet connection. The film is by the Blender Foundation and is licensed under [Creative Commons Attribution 3.0](https://bbb3d.renderfarming.net/download.html). The movie is not redistributed in this repository.

## What it demonstrates

- `ObservableCollection<MediaItem>` as the `ItemsSource`.
- Per-image durations and `Stretch` settings.
- A per-item video placeholder and looping option.
- `IsAutoPlay`, navigation buttons, indicators, blur background, and overlay opacity.
- A project reference to the pinned `WpfMediaCarousel` Git submodule.

## License

The application code and original image assets are MIT licensed; see [LICENSE](LICENSE). The linked film has the separate license described above.
