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
using WindowsFormsApp.Services;

namespace WindowsFormsApp.Forms
{
    public partial class ParentForm : Form
    {
        public int EntityId { get; set; } = -1;
        public ParentForm()
        {
            InitializeComponent();
        }

        public void HideBackButton()
        {
            backButton.Visible = false;
        }

        public void SetTitle(string title)
        {
            this.Text = title;
        }

        private void ParentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager.GoBack(this);
        }

        private void ShowUser()
        {
            if (UserSession.User != null)
            {
                fullNameLabel.Text = $"{UserSession.User.LastName} {UserSession.User.Name} {UserSession.User.PatronymicName}";
                roleLabel.Text = UserSession.User.UserRole;
            }
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            ShowUser();
            ShowCartIcon();
        }

        private void ShowCartIcon()
        {
            pictureBox2.Visible = OrderManager.CartExists();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Order cart = OrderManager.GetCart();

            OrderDetailForm detailForm = new OrderDetailForm();
            detailForm.EntityId = cart.OrderId;

            FormManager.NavigateTo(detailForm, this);
        }
    }
}
