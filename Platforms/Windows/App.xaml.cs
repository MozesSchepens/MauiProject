using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
namespace MauiProject.WinUI;

public partial class App : MauiWinUIApplication
{
    public App()
    {
        // GEEN InitializeComponent hier
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
