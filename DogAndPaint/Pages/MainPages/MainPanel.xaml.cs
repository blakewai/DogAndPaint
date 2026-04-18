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

namespace DogAndPoint.Pages.MainPages
{
    /// <summary>
    /// Логика взаимодействия для MainPanel.xaml
    /// </summary>
    public partial class MainPanel : Page
    {
        public MainPanel()
        {
            InitializeComponent();
            PanelLogic();
        }

        private void PanelLogic()
        {
            Logic.TitleWindowEdit.Title("Главная страница");
            FramesMainPanel.Navigate(new Uri("Pages/FrameMainPanel/Client/MainPagePanel.xaml", UriKind.RelativeOrAbsolute));
        }

        private void MainPanelBT_Click(object sender, RoutedEventArgs e)
        {
            PanelLogic();
        }

        private void MenuTB_Click(object sender, RoutedEventArgs e)
        {
            Logic.TitleWindowEdit.Title("Меню");
            FramesMainPanel.Navigate(new Uri("Pages/FrameMainPanel/Client/Menu.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ProfileTB_Click(object sender, RoutedEventArgs e)
        {
            Logic.TitleWindowEdit.Title("Профиль");
            FramesMainPanel.Navigate(new Uri("Pages/FrameMainPanel/Profile.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Address_Click(object sender, RoutedEventArgs e)
        {
            Logic.TitleWindowEdit.Title("Точки");
            FramesMainPanel.Navigate(new Uri("Pages/FrameMainPanel/Address.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
