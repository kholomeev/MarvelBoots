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

namespace WindowsFormsApp.Forms
{
    public partial class OrderDetailForm : ParentForm
    {
        private Order _order;
        public OrderDetailForm()
        {
            InitializeComponent();
        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            SelectData();
            ShowInfo();
        }
        
        private void ShowInfo()
        {
            _order = Program.context.Order.Find(EntityId);
        }

        private void SelectData()
        {
            clientLabel.Text = $"Клиент: {_order.User}";
            dateLabel.Text = $"Дата: {_order.OrderDate}";
            statusLabel.Text = $"Статус: {_order.Status}";
            grandTotalLabel.Text = $"Итого по заказу:\n{_order.GrandTotal()} руб.";

        }
    }
}
