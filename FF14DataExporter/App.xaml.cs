using FF14DataExporter.Views;

using Prism.Ioc;

using System.Windows;

namespace FF14DataExporter;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override Window CreateShell()
    {
        return Container.Resolve<MainWindow>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {

    }
}
