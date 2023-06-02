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
    /// Логика взаимодействия для GuestOrderData.xaml
    /// </summary>
    public partial class GuestOrderData : Page
    {
        private Order _order;
        public GuestOrderData(Order order)
        {
            InitializeComponent();

            _order = order;
        }

        private void SaveOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string firstName = FirstNameTB.Text;
                string middleName = MiddleNameTB.Text;
                string lastName = LastNameTB.Text;
                string address = AddressTB.Text;

                if(String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(middleName) || String.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Поля: Имя, Фамилия и Адрес обязательны к заполнению!");
                    return;
                }

                User user = new User()
                {
                    firstName = firstName,
                    middleName = middleName,
                    lastName = lastName,
                    address = address,
                    role = BookStoreDBContext.db.Roles.Where(r => r.id.Equals(RolesEnum.GUEST)).FirstOrDefault()
                };

                _order.user = user;

                foreach(OrderProduct orderProduct in _order.orderProducts)
                {
                    if(orderProduct.product.quantity - orderProduct.quantity < 0)
                    {
                        MessageBox.Show("Не хватает товара на складе");
                        return;
                    }
                    else
                    {
                        orderProduct.product.quantity -= orderProduct.quantity;
                    }
                }

                BookStoreDBContext.db.Orders.Add(_order);

                BookStoreDBContext.db.SaveChanges();

                GuestCart.orderProducts = new List<OrderProduct>();

                MessageBox.Show("Заказ оформлен!");

                FrameObject.frame.Navigate(new GuestProductsList());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
