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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
            Logic.TitleWindowEdit.Title("Авторизация");
        }

        private void AuthorizationBT_Click(object sender, RoutedEventArgs e)
        {
            //Прописать код Авторизации!!!!!
            this.NavigationService.Navigate(new Uri("Pages/MainPages/MainPanel.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Page_LayoutUpdated(object sender, EventArgs e)
        {
            TextAuthorizationL.FontSize = Logic.Size.TextSizeLogic(20);
            LogoTextBlock.FontSize = Logic.Size.TextSizeLogic(20);
            LogoImage.Height = Logic.Size.TextSizeLogic(10);
            LoginText.FontSize = Logic.Size.TextSizeLogic(30);
            PasswordText.FontSize = Logic.Size.TextSizeLogic(30);
            AuthorizationBT.FontSize = Logic.Size.TextSizeLogic(30);

            Logic.Size.TextBoxLogic(30, LoginTB, 40, 20);
            Logic.Size.TextPasswordLogic(30, PasswordPB, 40, 20);
        }
    }
}
