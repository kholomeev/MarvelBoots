namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [Key]
        public int OrderId { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        public int ShoesSize { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }
    }
}
