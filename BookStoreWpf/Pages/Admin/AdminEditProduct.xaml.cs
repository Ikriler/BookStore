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

namespace BookStoreWpf.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminEditProduct.xaml
    /// </summary>
    public partial class AdminEditProduct : Page
    {
        private Product _product;
        public AdminEditProduct(Product product)
        {
            InitializeComponent();

            _product = product;

            InitFields();
        }

        private void InitFields()
        {
            try
            {
                NameTB.Text = _product.name;
                DescriptionTB.Text = _product.description;
                QunatityTB.Text = _product.quantity.ToString();
                ImagePathTB.Text = _product.imagePath;
                PriceTB.Text = _product.price.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = NameTB.Text;
                string description = DescriptionTB.Text;
                string imagePath = ImagePathTB.Text;
                int quantity = Int32.Parse(QunatityTB.Text);
                double price = Double.Parse(PriceTB.Text);

                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description))
                {
                    MessageBox.Show("Поля название и описание не должные быть пустыми!");
                    return;

                }
                _product.name = name;
                _product.description = description;
                _product.price = price;
                _product.quantity = quantity;
                _product.imagePath = imagePath;

                BookStoreDBContext.db.SaveChanges();

                MessageBox.Show("Товар изменен");

                FrameObject.frame.Navigate(new AdminProductsPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
