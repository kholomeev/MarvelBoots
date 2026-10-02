namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShoesSize")]
    public partial class ShoesSize
    {
        public int ShoesSizeId { get; set; }

        public int? ProductId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PossibleSize { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvailableSize { get; set; }

        public virtual Product Product { get; set; }
    }
}
