using DogAndPoint.Logic;
using Octokit;
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

namespace DogAndPoint.Pages.PagesProfiles
{
    /// <summary>
    /// Логика взаимодействия для AboutAplocation.xaml
    /// </summary>
    public partial class AboutAplocation : System.Windows.Controls.Page
    {
        public AboutAplocation()
        {
            InitializeComponent();
            
            Loaded += AboutAplocation_Loaded;

            Logic.TitleWindowEdit.Title("О приложении");
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
                VersionInfo.Text = $"Версия: {info.Version}";
            }
            catch (Exception ex)
            {
                AplocationInfo.Text = $"Не удалось загрузить данные {ex.Message}";
            }
        }

        private void BackTB_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
