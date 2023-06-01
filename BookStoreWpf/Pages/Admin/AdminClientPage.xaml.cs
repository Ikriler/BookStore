using BookStoreWpf.Enums;
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
    /// Логика взаимодействия для AdminClientPage.xaml
    /// </summary>
    public partial class AdminClientPage : Page
    {
        public AdminClientPage()
        {
            InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ClientDG.ItemsSource = await BookStoreDBContext.db.Users.Include(u => u.role).Where(u => u.role.id.Equals((int)RolesEnum.CLIENT)).ToListAsync();
        }
    }
}
