namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Orders = new HashSet<Orders>();
            ShoesSize = new HashSet<ShoesSize>();
        }

        public int ProductId { get; set; }

        public int ShoesType { get; set; }

        public int ShoesSubtype { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }

        public int ManufacturerId { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public int? ShoeTop { get; set; }

        public int? ShoeLiner { get; set; }

        public int? ShoeInsole { get; set; }

        public int? ShoeSole { get; set; }

        [StringLength(500)]
        public string ShoeOther { get; set; }

        public int Price { get; set; }

        public int AvailablePairQuantity { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual MaterialInsole MaterialInsole { get; set; }

        public virtual MaterialLiner MaterialLiner { get; set; }

        public virtual MaterialSole MaterialSole { get; set; }

        public virtual MaterialTop MaterialTop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        public virtual ShoesSubtype ShoesSubtype1 { get; set; }

        public virtual ShoesType ShoesType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoesSize> ShoesSize { get; set; }
    }
}
