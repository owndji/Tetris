using System.Windows;
using System.Windows.Controls;

namespace Tetris
{
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PlayGame_Click(object sender, RoutedEventArgs e)
        {
            // Créer et afficher MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }


        private void OpenOptions_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OptionsPage());
        }

        private void ExitGame_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
