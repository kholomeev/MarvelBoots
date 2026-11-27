using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Services
{
    internal class StockValidator
    {
        internal static void NonNegative(int idProduct, decimal size, int amount)
        {
            // STUD Узнаем остаток товара на складе.
            ShoesSize shoesSize = Program.context.ShoesSize.Where(ps => ps.ProductId == idProduct && ps.Size == size).First();
            int stock = shoesSize.PairQuantity;
            // STUD Получаем корзину.
            Order cart = OrderManager.GetCart();
            // STUD Суммируем, сколько этого товара/размера уже в корзине.
            int cartAmount = cart.OrderProduct.Where(op => op.IdProduct == idProduct && op.Size == size).Sum(op => op.Amount);
            // STUD Определяем, сколько этого товара/размера покупатель желает купить.
            int toBeOrdered = cartAmount + amount;
            // STUD Сверяем с остатком.
            int leftover = shoesSize.PairQuantity - toBeOrdered;
            // STUD Если перебор, сообщаем, сколько пользователь хочет, а сколько реально есть.
            if (leftover < 0)
            {
                throw new ValidationException($"Вы заказываете {toBeOrdered} с учетом товара в корзине. Это больше, чем есть на складе. Товарный запас {shoesSize.PairQuantity} шт.");
            }
        }
    }
}
