using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Services
{
    class AuthManager
    {
        /// <summary>
        /// STUD
        /// Аутентификация.
        /// </summary>

        public static void Login(string username)
        {
            User user = Program.context.User
                .Where(u => u.Login == username)
                .First();

            UserSession.User = user;
        }

    }

}