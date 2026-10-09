using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Forms;
using WindowsFormsApp.Models;

namespace WindowsFormsApp
{
    internal static class Program
    {
        public static MarvelBoots context = new MarvelBoots();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!context.Database.Exists())
            {
                MessageBox.Show("Ошибка соединения с базой данных",
                    "Ошибка соединения с базой данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
