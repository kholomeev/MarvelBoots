using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Services;

namespace WindowsFormsApp.Forms
{
    public partial class LoginForm : ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
            HideBackButton();
            SetTitle("Вход");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                AuthManager.Login(usernametextBox.Text);
                FormManager.NavigateTo(new ProductListForm(), this);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Имя пользователя неверно.", "Имя пользователя неверно.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthManager.Login("g");
            FormManager.NavigateTo(new ProductListForm(), this);
        }
    }
}
