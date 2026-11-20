using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Services
{
    internal class OrderManager
    {
        private static User GetCartOwner() {
            return UserSession.User;
        }

        public static Orders CreateCart(User user)
        {
            Orders order = new Orders();
            order.User = user;
            //order.Status = Constant.Cart;
            order.OrderDate = DateTime.Now;
            Program.context.Orders.Add(order);
            Program.context.SaveChanges();
            return order;

        }

        internal static void CreateOrUpdateOrderProduct(Product product, decimal size, int amount)
        {
            throw new NotImplementedException();
        }

        internal static Orders GetOrCreateCart()
        {
            throw new NotImplementedException();
        }
    }
}
