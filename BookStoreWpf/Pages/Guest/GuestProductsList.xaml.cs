using BookStoreWpf.Models;
using BookStoreWpf.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace BookStoreWpf.Pages.Guest
{
    /// <summary>
    /// Логика взаимодействия для GuestProductsList.xaml
    /// </summary>
    public partial class GuestProductsList : Page
    {
        public GuestProductsList()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateItems();
        }

        private void UpdateItems()
        {
            List<Product> products = BookStoreDBContext.db.Products.ToList();
            ProductsLV.ItemsSource = null;
            ProductsLV.ItemsSource = products;
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = (sender as Button).DataContext as Product;
                GuestCart.orderProducts.Add(new OrderProduct() 
                {
                    product = product,
                    quantity = 1
                });
                UpdateItems();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class ProductIDValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int idProduct = (int)value;
            return GuestCart.orderProducts.Select(p => p.product.id).Contains(idProduct);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
