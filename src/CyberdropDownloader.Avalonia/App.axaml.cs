using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using CyberdropDownloader.Avalonia.Views;
using CyberdropDownloader.Core;

namespace CyberdropDownloader.Avalonia
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            FileDownloader.Initialize();
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow()
                {
                    #region Disable Native TitleBar
                    ExtendClientAreaToDecorationsHint = true,
                    ExtendClientAreaChromeHints = ExtendClientAreaChromeHints.NoChrome,
                    ExtendClientAreaTitleBarHeightHint = -1,
                    #endregion
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}