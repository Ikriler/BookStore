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
    /// Логика взаимодействия для AdminCreateProduct.xaml
    /// </summary>
    public partial class AdminCreateProduct : Page
    {
        public AdminCreateProduct()
        {
            InitializeComponent();
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
                
                if(String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description))
                {
                    MessageBox.Show("Поля название и описание не должные быть пустыми!");
                    return;
                }

                Product product = new Product 
                {
                    name = name,
                    description = description,
                    price = price,
                    quantity = quantity,
                    imagePath = imagePath
                };

                BookStoreDBContext.db.Products.Add(product);

                BookStoreDBContext.db.SaveChanges();

                MessageBox.Show("Товар добавлен");

                FrameObject.frame.Navigate(new AdminProductsPage());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
