using BookStoreWpf.Enums;
using BookStoreWpf.Models;
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

namespace BookStoreWpf.Pages.Guest
{
    /// <summary>
    /// Логика взаимодействия для GuestOrder.xaml
    /// </summary>
    public partial class GuestOrder : Page
    {
        public GuestOrder()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {

            if (GuestCart.orderProducts.Count == 0)
            {
                CreateOrder.Visibility = Visibility.Collapsed;
                InfoMessage.Visibility = Visibility.Visible;
            }
            else
            {
                InfoMessage.Visibility = Visibility.Collapsed;
                CreateOrder.Visibility = Visibility.Visible;
            }
        }

        private void UpdateItems()
        {
            List<OrderProduct> orderProducts = GuestCart.orderProducts;

            ProductsLV.ItemsSource = null;

            ProductsLV.ItemsSource = orderProducts;
        }

        private double CalculateAmount(List<OrderProduct> orderProducts)
        {
            double amount = 0;
            
            foreach (OrderProduct orderProduct in orderProducts) 
            {
                amount += orderProduct.product.price * orderProduct.quantity;
            }

            return amount;
        }

        private void CreateOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order order = new Order() 
                {
                    dateTime = DateTime.Now,
                    orderProducts = GuestCart.orderProducts,
                    amountPrice = CalculateAmount(GuestCart.orderProducts),
                    status = BookStoreDBContext.db.Statuses.Where(s => s.id.Equals(StatusesEnum.CREATED)).FirstOrDefault()
                };

                FrameObject.frame.Navigate(new GuestOrderData(order));
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateItems();
        }

        private void DeleteOneQuantity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderProduct orderProduct = (sender as Button).DataContext as OrderProduct;

                if (orderProduct.quantity <= 1)
                {
                    GuestCart.orderProducts.Remove(orderProduct);
                }
                else
                {
                    orderProduct.quantity--;
                }
                UpdateItems();
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddOneQuantity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderProduct orderProduct = (sender as Button).DataContext as OrderProduct;

                if (orderProduct.quantity < orderProduct.product.quantity)
                {
                    orderProduct.quantity++;
                }
                else
                {
                    MessageBox.Show("Выбрано максимальное количество товара");
                }
                UpdateItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
