using DogAndPower.Logic;
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

namespace DogAndPower.Pages.PagesProfiles
{
    /// <summary>
    /// Логика взаимодействия для AboutAplocation.xaml
    /// </summary>
    public partial class AboutAplocation : Page
    {
        public AboutAplocation()
        {
            InitializeComponent();
            Loaded += AboutAplocation_Loaded;
        }

        private async void AboutAplocation_Loaded(object sender, RoutedEventArgs e)
        {
            await WriteInfo();
        }

        public async Task WriteInfo()
        {
            try
            {
                AplocationInfo.Text = "Загрузка данных...";

                var info = await GitHubInfo.GitHubInformation();

                AplocationInfo.Text = $"Приложение: {info.Name}";
            }
            catch (Exception ex)
            {
                AplocationInfo.Text = $"Не удалось загрузить данные {ex.Message}";
            }
        }
    }
}
