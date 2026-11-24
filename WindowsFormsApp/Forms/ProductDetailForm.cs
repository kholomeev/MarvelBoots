using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Graph.Models;
using WindowsFormsApp.Models;
using WindowsFormsApp.Services;

namespace WindowsFormsApp.Forms
{
    public partial class ProductDetailForm : ParentForm
    {
        private Product _product;
        public ProductDetailForm()
        {
            InitializeComponent();
            SetTitle("Карточка товара");
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            SelectData();
            ShowInfo();
            FillSizeComboBox();
        }

        private void FillSizeComboBox()
        {
            List<ShoesSize> sizes = Program.context.ShoesSize
                .Where(p => p.ProductId == _product.ProductId && p.PairQuantity > 0)
                .OrderBy(p => p.Size)
                .ToList();

            sizeComboBox.DataSource = sizes;
        }

        private void SelectData()
        {
            _product = Program.context.Product.Find(EntityId);
        }

        private void ShowInfo()
        {
            manufacturerLabel.Text = $"Производитель: {_product.Manufacturer.ManufacturerName}";
            productNameLabel.Text = $"Наименование: {_product.ProductName}";
            categoryLabel.Text = $"Категория: {_product.ShoesType}";
            subсategoryLabel.Text = $"Подкатегория: {_product.ShoesSubtype}";
            stockLabel.Text = $"Количество: {_product.GetStock()}";
            compositionLabel.Text = $"Состав: {_product.Composition}";
            descriptionLabel.Text = $"Описание: {_product.Description}";
            sizeRangeLabel.Text = $"Размерный ряд: {_product.GetSizeRange()}";
            priceLabel.Text = $"Цена:\n {_product.GetPrice()} руб.";
            idLabel.Text = $"Id: {_product.ProductId}";
            photoPictureBox.Image = _product.GetImage();
        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            // STUD С формы получить данные (товар, размер, количество).
            decimal size = ((ShoesSize)sizeComboBox.SelectedItem).Size;
            int amount = (int)amointNumericUpDown.Value;
            // STUD Получить корзину (заказ в статусе корзина).
            Order cart = OrderManager.GetOrCreateCart();
            try
            {
                // STUD Валидация(вдруг нехватка товара данного размера)
                StockValidator.NonNegative(_product.ProductId, size, amount);
                // STUD Добавить товары к заказу.
                OrderManager.CreateOrUpdateOrderProduct(_product, size, amount);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // STUD Сообщить пользователю.
            MessageBox.Show("Товар добавлен в корзину",
                  "Товар добавлен в корзину",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            // STUD Переадресовать в каталог.
            FormManager.NavigateTo(new ProductListForm(), this);
        }
    }
}
