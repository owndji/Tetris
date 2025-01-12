using System.Windows;
using System.Windows.Controls;

namespace Tetris
{
    public partial class OptionsPage : Page
    {
        public OptionsPage()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }
    }
}
