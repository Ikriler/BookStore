using BookStoreWpf.Models;
using BookStoreWpf.Utils;
using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для AdminProductsPage.xaml
    /// </summary>
    public partial class AdminProductsPage : Page
    {
        public AdminProductsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateProductList();
        }

        private async void UpdateProductList()
        {
            List<Product> products = await BookStoreDBContext.db.Products.ToListAsync();
            ProductsLV.ItemsSource = null;
            ProductsLV.ItemsSource = products;
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            ProductsLV.Items.Filter = Contains;
        }

        private bool Contains(object value)
        {
            Product product = value as Product;

            return product.name.ToLower().Contains(SearchTB.Text.ToLower())
                || product.description.ToLower().Contains(SearchTB.Text.ToLower());
        }

        private void EditProduct_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Product product = (sender as Button).DataContext as Product;

                FrameObject.frame.Navigate(new AdminEditProduct(product));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = (sender as Button).DataContext as Product;

                BookStoreDBContext.db.Products.Remove(product);

                BookStoreDBContext.db.SaveChanges();

                UpdateProductList();

                MessageBox.Show("Товар удален!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameObject.frame.Navigate(new AdminCreateProduct());
        }
    }
}
