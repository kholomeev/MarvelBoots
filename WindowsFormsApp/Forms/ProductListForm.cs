using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;
using WindowsFormsApp.UserControls;

namespace WindowsFormsApp.Forms
{
    public partial class ProductListForm : ParentForm
    {
        private List<Product> _products;
        public ProductListForm()
        {
            InitializeComponent();
            SetTitle("Каталог товаров");
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            SelectProducts();
            ShowProducts();
        }

        private void SelectProducts()
        {
            _products = Program.context.ShoesSize.
                Where(p => p.PairQuantity > 0).
                Select(p => p.Product).
                Distinct().ToList();
        }

        private void ShowProducts()
        {
            foreach (Product product in _products)
            {
                flowLayoutPanel.Controls.Add(new ProductControl());
            }
        }
    }
}
