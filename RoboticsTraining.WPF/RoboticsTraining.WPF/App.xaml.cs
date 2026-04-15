using RoboticsTraining;
using RoboticsTraining.WPF.ViewModels;
using RoboticsTraining.WPF.Views;
using System.Windows;

namespace RoboticsTraining.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var viewModel = new MainViewModel("IRB 120", new Position(1.0, 2.0, 3.0));
            var mainWindow = new MainWindow();
            mainWindow.DataContext = viewModel;
            mainWindow.Show();
        }
    }

}
