using System;
using System.Windows;
using System.Windows.Controls;

namespace DogAndPoint.Logic
{
    internal class Size
    {
        private static Window _cachedMainWindow;

        private static void UpdateCachedWindow()
        {
            if (Application.Current != null && Application.Current.MainWindow != _cachedMainWindow)
            {
                _cachedMainWindow = Application.Current.MainWindow;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //Size TextBlock!!!!
        public static double TextSizeLogic(double speedsize)
        {
            UpdateCachedWindow();

            if (_cachedMainWindow == null || speedsize <= 0)
                return 0.0;

            return _cachedMainWindow.ActualHeight / speedsize;
        }
        public static double TextSizeLogic(double speedsize, double maxsize)
        {
            UpdateCachedWindow();

            if (_cachedMainWindow == null || speedsize <= 0)
                return 0.0;
            if (_cachedMainWindow.ActualHeight / speedsize < maxsize)
                return maxsize;

            return _cachedMainWindow.ActualHeight / speedsize;
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //Size TextBox!!!!
        public static TextBox TextBoxLogic(double speedsize, TextBox textBox, double HeightMax, double HeightMin)
        {
            if (textBox == null) return textBox;

            UpdateCachedWindow();

            if (_cachedMainWindow != null && speedsize > 0)
            {
                double newHeight = _cachedMainWindow.ActualHeight / speedsize;
                
                textBox.Height = Math.Max(HeightMin, Math.Min(HeightMax, newHeight));
                textBox.FontSize = Math.Max(HeightMin - 10, Math.Min(HeightMax - 10, newHeight - 10));
            }

            return textBox;
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //Size PasswordBox
        public static PasswordBox TextPasswordLogic(double speedsize, PasswordBox passwordBox, double HeightMax, double HeightMin)
        {
            if (passwordBox == null) return passwordBox;

            UpdateCachedWindow();

            if (_cachedMainWindow != null && speedsize > 0)
            {
                double newHeight = _cachedMainWindow.ActualHeight / speedsize;
                passwordBox.Height = Math.Max(HeightMin, Math.Min(HeightMax, newHeight));
                passwordBox.FontSize = Math.Max(HeightMin - 10, Math.Min(HeightMax - 10, newHeight - 10));
            }

            return passwordBox;
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //Size 

    }
}