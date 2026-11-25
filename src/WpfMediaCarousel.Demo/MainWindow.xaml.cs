using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using MediaCarousel.Models;

namespace WpfMediaCarousel.Demo;

public partial class MainWindow : Window
{
    public ObservableCollection<MediaItem> MediaItems { get; } = new();

    public ImageSource VideoPlaceholder { get; }

    public MainWindow()
    {
        VideoPlaceholder = new BitmapImage(AssetUri("nw.png"));

        MediaItems.Add(
            new MediaItem(MediaType.Image, AssetUri("scene-01.png"))
            {
                Duration = TimeSpan.FromSeconds(6),
                Stretch = Stretch.UniformToFill,
                Tag = "01 / Atmosphere",
                TagPlaceholder = "Original demo artwork",
            }
        );
        MediaItems.Add(
            new MediaItem(MediaType.Image, AssetUri("scene-02.png"))
            {
                Duration = TimeSpan.FromSeconds(6),
                Stretch = Stretch.UniformToFill,
                Tag = "02 / Evening",
                TagPlaceholder = "Original demo artwork",
            }
        );
        MediaItems.Add(
            new MediaItem(MediaType.Image, AssetUri("scene-03.png"))
            {
                Duration = TimeSpan.FromSeconds(6),
                Stretch = Stretch.UniformToFill,
                Tag = "03 / Green",
                TagPlaceholder = "Original demo artwork",
            }
        );
        MediaItems.Add(
            new MediaItem(MediaType.Video, AssetUri("naiwa.mp4"))
            {
                IsLoop = false,
                Stretch = Stretch.Uniform,
                PlaceholderSource = VideoPlaceholder,
                TagPlaceholder = "Video sample · CC BY 3.0",
            }
        );
        MediaItems.Add(
            new MediaItem(MediaType.Image, AssetUri("04.jpg"))
            {
                Duration = TimeSpan.FromSeconds(6),
                Stretch = Stretch.UniformToFill,
                TagPlaceholder = "Original demo artwork",
            }
        );

        InitializeComponent();
        DataContext = this;
    }

    private static Uri AssetUri(string fileName) =>
        new(Path.Combine(AppContext.BaseDirectory, "Assets", fileName), UriKind.Absolute);
}
