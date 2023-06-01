using BookStoreWpf.Enums;
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

namespace BookStoreWpf.Pages.Client
{
    /// <summary>
    /// Логика взаимодействия для ClientCartPage.xaml
    /// </summary>
    public partial class ClientCartPage : Page
    {

        private User _user;
        public static Order order;
        public ClientCartPage(User user)
        {
            InitializeComponent();

            _user = user;

            order = BookStoreDBContext.db.Orders.Include(o => o.user).Include(o => o.status).Where(o => o.user.Equals(_user) && o.status.id.Equals((int)StatusesEnum.CART)).FirstOrDefault();

            if (order != null)
            {
                ProductsLV.ItemsSource = order.orderProducts;
            }
        }


    }
}
