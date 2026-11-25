using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using MediaCarousel.Models;

namespace WpfMediaCarousel.Demo;

public partial class MainWindow : Window
{
    private static readonly Uri BigBuckBunnyUri = new(
        "https://storage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4",
        UriKind.Absolute
    );

    public ObservableCollection<MediaItem> MediaItems { get; } = new();

    public ImageSource VideoPlaceholder { get; }

    public MainWindow()
    {
        VideoPlaceholder = new BitmapImage(AssetUri("scene-03.png"));

        MediaItems.Add(new MediaItem(MediaType.Image, AssetUri("scene-01.png"))
        {
            Duration = TimeSpan.FromSeconds(6),
            Stretch = Stretch.UniformToFill,
            Tag = "01 / Atmosphere",
            TagPlaceholder = "Original demo artwork"
        });
        MediaItems.Add(new MediaItem(MediaType.Image, AssetUri("scene-02.png"))
        {
            Duration = TimeSpan.FromSeconds(6),
            Stretch = Stretch.UniformToFill,
            Tag = "02 / Evening",
            TagPlaceholder = "Original demo artwork"
        });
        MediaItems.Add(new MediaItem(MediaType.Image, AssetUri("scene-03.png"))
        {
            Duration = TimeSpan.FromSeconds(6),
            Stretch = Stretch.UniformToFill,
            Tag = "03 / Green",
            TagPlaceholder = "Original demo artwork"
        });
        MediaItems.Add(new MediaItem(MediaType.Video, BigBuckBunnyUri)
        {
            IsLoop = false,
            Stretch = Stretch.Uniform,
            PlaceholderSource = VideoPlaceholder,
            Tag = "04 / Big Buck Bunny",
            TagPlaceholder = "Video sample · CC BY 3.0"
        });

        InitializeComponent();
        DataContext = this;
    }

    private static Uri AssetUri(string fileName) => new(
        Path.Combine(AppContext.BaseDirectory, "Assets", fileName),
        UriKind.Absolute
    );
}
