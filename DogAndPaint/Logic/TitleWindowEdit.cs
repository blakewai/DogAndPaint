using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DogAndPoint.Logic
{
    internal class TitleWindowEdit
    {
        public static void Title(string Titlename)
        {
            var Titleinfo = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (Titleinfo != null)
            {
                Titleinfo.Title = Titlename;
            }
        }
    }
}
