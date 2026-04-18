using DogAndPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DogAndPoint.Pages.FrameMainPanel
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void DataUserBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CityTB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HistoryTB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HelpTB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AboutAplocationTB_Click(object sender, RoutedEventArgs e)
        {
            var windowsframe = Application.Current.MainWindow as MainWindow;
            if (windowsframe != null)
            {
                windowsframe.MainFrame.Navigate(new Uri("Pages\\PagesProfiles\\AboutAplocation.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}
