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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookStoreWpf.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminMainPage.xaml
    /// </summary>
    public partial class AdminMainPage : Page
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void GoClients_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame.Navigate(new AdminClientPage());
        }

        private void GoProducts_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame.Navigate(new AdminProductsPage());
        }

        private void GoOrders_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame.Navigate(new AdminOrdersPage());
        }
    }
}
