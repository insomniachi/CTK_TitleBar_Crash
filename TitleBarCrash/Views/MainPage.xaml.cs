using Microsoft.UI.Xaml.Controls;

using TitleBarCrash.ViewModels;

namespace TitleBarCrash.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void MediaPlayerElement_DoubleTapped(object sender, Microsoft.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
    {
        if (App.MainWindow.PresenterKind == Microsoft.UI.Windowing.AppWindowPresenterKind.Overlapped)
        {
            App.MainWindow.PresenterKind = Microsoft.UI.Windowing.AppWindowPresenterKind.FullScreen;
        }
        else
        {
            App.MainWindow.PresenterKind = Microsoft.UI.Windowing.AppWindowPresenterKind.Overlapped;
        }

    }
}
