namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderProduct")]
    public partial class OrderProduct
    {
        [Key]
        public int IdOrderProduct { get; set; }

        public int IdOrder { get; set; }

        public int IdProduct { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Size { get; set; }

        public int Amount { get; set; }

        public decimal OrderProductPrice { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
