using BookStoreWpf.Enums;
using BookStoreWpf.Models;
using BookStoreWpf.Utils;
using BookStoreWpf.Windows;
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
using System.Windows.Shapes;

namespace BookStoreWpf
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            if(BookStoreDBContext.db == null)
            {
                BookStoreDBContext.db = new BookStoreDBContext();
            }
        }

        private void UserEnterBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = BookStoreDBContext.db.Users.Where(u => u.email.Equals(EmailTB.Text) && u.password.Equals(PasswordPB.Password)).Include(u => u.role).FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return;
                }

                switch (user.role.id)
                {
                    case (int)RolesEnum.CLIENT:
                        OpenWindow(new ClientWindow(user));
                        break;
                    case (int)RolesEnum.ADMIN:
                        OpenWindow(new AdminWindow());
                        break;
                    case (int)RolesEnum.MANAGER:
                        OpenWindow(new ManagerWindow());
                        break;
                    default:
                        MessageBox.Show("Не найдено окон для данной роли!");
                        break;
                }

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void OpenWindow(Window window)
        {
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }

        private void AdminEnterTestBtn_Click(object sender, RoutedEventArgs e)
        {
            EmailTB.Text = "admin@mail.ru";
            PasswordPB.Password = "admin";

            UserEnterBtn_Click(sender, e);
        }

        private void ClientEnterTestBtn_Click(object sender, RoutedEventArgs e)
        {
            EmailTB.Text = "client@mail.ru";
            PasswordPB.Password = "client";

            UserEnterBtn_Click(sender, e);
        }

        private void ManagerEnterTestBtn_Click(object sender, RoutedEventArgs e)
        {
            EmailTB.Text = "manager@mail.ru";
            PasswordPB.Password = "manager";

            UserEnterBtn_Click(sender, e);
        }
    }
}
