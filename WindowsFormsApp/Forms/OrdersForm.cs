using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Forms
{
    public partial class OrdersForm : ParentForm
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "holomeev_marvelbootsDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.holomeev_marvelbootsDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "holomeev_marvelbootsDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.holomeev_marvelbootsDataSet.Orders);

        }
    }
}
