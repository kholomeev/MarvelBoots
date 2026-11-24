using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Constants;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Services
{
    internal class OrderManager
    {
        private static User GetCartOwner() {
            return UserSession.User;
        }

        public static Order GetCart(User user)
        {
            var cartOwner = GetCartOwner();
            if (cartOwner == null)
            {
                return null;
            }

            return Program.context.Order
                .FirstOrDefault(o => o.Status == Constant.Cart
                && o.UserId == cartOwner.IdUser
                && o.OrderId > Constant.LastOrderInClosedPeriod);
        }

        public static Order CreateCart(User user)
        {
            Order order = new Order();
            order.User = user;
            order.Status = Constant.Cart;
            order.OrderDate = DateTime.Now;
            Program.context.Order.Add(order);
            Program.context.SaveChanges();
            return order;
        }

        internal static void CreateOrUpdateOrderProduct(Product product, decimal size, int amount)
        {
            // STUD Консолидировать заказ: при совпадении товара
            // и размера не создавать новую запись в таблице, а добавить к существующей.
            Order cart = GetCart();

            Order existing = cart.OrderProduct.Where(op => op.Product.ProductId == product.ProductId && op.Order.ShoesSize == size).FirstOrDefault();

            if (existing != null)
            {
                
            }
            else
            {
                // STUD Товара в корзине нет - просто создаем запись.
                OrderProduct orderProduct = new OrderProduct();
                orderProduct.Order = cart;
                orderProduct.Product = product;
                orderProduct.Size = size;
                orderProduct.Amount = amount;
                orderProduct.OrderProductPrice = product.GetPrice();
                Program.context.OrderProduct.Add(orderProduct);
            }

            Program.context.SaveChanges();
        }

        internal static Order GetOrCreateCart()
        {
            Order cart = GetCart();
            if (cart == null)
            {
                cart = CreateCart(GetCartOwner());
            }

            return cart;
        }
    }
}
