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
    public partial class OrderForm : ParentForm
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "holomeev_marvelbootsDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.holomeev_marvelbootsDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "holomeev_marvelbootsDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.OrderTableAdapter.Fill(this.holomeev_marvelbootsDataSet.Order);

        }
    }
}
