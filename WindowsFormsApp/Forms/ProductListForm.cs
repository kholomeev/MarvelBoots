using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;
using WindowsFormsApp.Services;
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
            categoryComboBox.SelectedIndex = 0;
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            ClearProducts();
            SelectProducts();
            ShowProducts();
        }

        private void ClearProducts()
        {
            flowLayoutPanel.Controls.Clear();
        }

        private void SelectProducts()
        {
            string searchInput = textBox1.Text.Trim();
            bool cheapFirstInput = cheapFirst.Checked;
            string categoryInput = (string)categoryComboBox.SelectedItem;

            IQueryable<Product> tmpProducts = Program.context.ShoesSize.
                Where(p => p.PairQuantity > 0).
                Select(p => p.Product).
                Distinct();

            if (!String.IsNullOrEmpty(searchInput))
            {
                tmpProducts = tmpProducts.Where(obj => DbFunctions.Like(obj.ProductName, "%" + searchInput + "%") || DbFunctions.Like(obj.Description, "%" + searchInput + "%"));
            }

            if (!String.IsNullOrEmpty(categoryInput) && categoryInput != "Все категории")
            {
                tmpProducts = tmpProducts.Where(p => p.ShoesType == categoryInput);
            }

            _products = tmpProducts.ToList();

            _products = cheapFirstInput ?
                _products.OrderBy(p => p.GetPrice()).ToList() :
                _products.OrderByDescending(p => p.GetPrice()).ToList();
        }

        private void ShowProducts()
        {
            foreach (Product product in _products)
            {
                flowLayoutPanel.Controls.Add(new ProductControl(product));
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void cheapFirst_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void expensiveFirst_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo(new OrdersForm(), this);
        }
    }
}
