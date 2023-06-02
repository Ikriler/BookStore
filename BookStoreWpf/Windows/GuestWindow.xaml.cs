using BookStoreWpf.Models;
using BookStoreWpf.Pages.Client;
using BookStoreWpf.Pages.Guest;
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
    /// Логика взаимодействия для GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        public GuestWindow()
        {
            InitializeComponent();

            FrameObject.frame = GuestFrame;

            FrameObject.frame.Navigate(new GuestProductsList());
        }

        private void GoMain_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame.Navigate(new GuestProductsList());
        }

        private void GoExit_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame = null;

            Window window = new LoginWindow();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
            this.Close();
        }

        private void GoOrder_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame.Navigate(new GuestOrder());
        }
    }
}
