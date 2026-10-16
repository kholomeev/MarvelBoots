namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
            ShoesSize = new HashSet<ShoesSize>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string ShoesType { get; set; }

        [Required]
        [StringLength(50)]
        public string ShoesSubtype { get; set; }

        [Required]
        [StringLength(50)]
        public string Image { get; set; }

        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }

        public int ManufacturerId { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(500)]
        public string Composition { get; set; }

        public int Price { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoesSize> ShoesSize { get; set; }

        /// <summary>
        /// STUD
        ///
        /// Рассчитать цену товара (рубли) с учетом скидки: 25% на товары, на
        /// которые не было заказов в апреле текущего года.
        ///
        /// </summary>
        /// <returns>Decimal</returns>
        public Decimal GetPrice()
        {

            int currentYear = DateTime.Now.Year;

            bool hasSales = Program.context.OrderProduct.Count(op => op.IdProduct == this.ProductId &&
                           op.Orders.OrderDate.Year == currentYear &&
                           op.Orders.OrderDate.Month == 4) > 0; // STUD Апрель.

            Decimal result = Price;

            if (!hasSales)
            {
                result = Math.Round(Price * 0.75m, 2); // STUD Скидка 25 %.
            }

            return result;

        }

        /// <summary>
        /// STUD
        ///
        /// Количество: «много», если более пяти единиц товарных
        /// позиций и «мало», если менее или равно пяти.
        ///
        /// </summary>
        ///
        /// <returns>String</returns>
        public string GetStock()
        {
            int stock = ShoesSize.Sum(p => p.PairQuantity);

            string result = "";

            if (stock > 5)
            {
                result = "Много";
            }
            else
            {
                result = "Мало";
            }

            return result;

        }
    }
}
