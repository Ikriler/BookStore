using BookStoreWpf.Enums;
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

namespace BookStoreWpf.Pages.Client
{
    /// <summary>
    /// Логика взаимодействия для ClientProductsListPage.xaml
    /// </summary>
    public partial class ClientProductsListPage : Page
    {
        private User _user;
        public static Order order;
        public ClientProductsListPage(User user)
        {
            InitializeComponent();

            _user = user;

            order = BookStoreDBContext.db.Orders.Include(o => o.user).Include(o => o.status).Include(o => o.orderProducts).Where(o => o.user.Equals(_user) && o.status.id.Equals((int)StatusesEnum.CART)).FirstOrDefault();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateProductList();
        }

        private async void UpdateProductList()
        {
            List<Product> products = await BookStoreDBContext.db.Products.ToListAsync();

            //if (order != null && order.orderProducts != null)
            //{
            //    products = products.Except(order.orderProducts.Select(o => o.product)).ToList();
            //}

            ProductsLV.ItemsSource = products;
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = (sender as Button).DataContext as Product;

                if (order == null)
                {
                    Status status = BookStoreDBContext.db.Statuses.Where(s => s.id.Equals((int)StatusesEnum.CART)).FirstOrDefault();
                    Order orderCart = new Order
                    {
                        status = status,
                        user = _user
                    };
                    order = orderCart;
                    BookStoreDBContext.db.Orders.Add(order);
                }
                if (!order.orderProducts.Select(o => o.product).ToList().Contains(product))
                {
                    OrderProduct orderProduct = new OrderProduct()
                    {
                        product = product,
                        quantity = 1
                    };
                    order.orderProducts.Add(orderProduct);
                    UpdateProductList();
                    MessageBox.Show("Товар добавлен в корзину!");
                }
                BookStoreDBContext.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }

    public class ProductAccessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Product product = BookStoreDBContext.db.Products.Where(p => p.id.Equals((int)value)).FirstOrDefault();
            if (ClientProductsListPage.order != null && product != null)
            {
                return ClientProductsListPage.order.orderProducts.Select(o => o.product).Contains(product);
            }
            return false;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
