using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.UserControls
{
    public partial class ProductControl : UserControl
    {
        private Product _product;
        public ProductControl(Product product)
        {
            InitializeComponent();
            _product = product;
            ShowInfo();
        }

        private void ShowInfo()
        {
            manufacturerLabel.Text = $"{_product.Manufacturer.ManufacturerName} | {_product.ProductName}";
            categoryLabel.Text = $"Категория: {_product.ShoesType}";
            stockLabel.Text = $"Количество: {_product.GetStock()}";
            compositionLabel.Text = $"Состав: {_product.Composition}";
            priceLabel.Text = $"Цена:\n {_product.GetPrice()} руб.";
            idLabel.Text = $"Id: {_product.ProductId}";
        }

    }
}
