using BookStoreWpf.Pages.Admin;
using BookStoreWpf.Utils;
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
using System.Windows.Shapes;

namespace BookStoreWpf.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();

            FrameObject.frame = AdminFrame;

            FrameObject.frame.Navigate(new AdminMainPage());
        }

        private void GoMain_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame.Navigate(new AdminMainPage());
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (FrameObject.frame.CanGoBack) 
            {
                FrameObject.frame.GoBack();
            }
        }

        private void GoExit_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame = null;

            Window window = new LoginWindow();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
            this.Close();
        }
    }
}
