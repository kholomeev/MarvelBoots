namespace WindowsFormsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int IdUser { get; set; }

        [Required]
        [StringLength(150)]
        public string NameUser { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        public int UserRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        public virtual UserRole UserRole1 { get; set; }

        // STUD {

        //public override string ToString()
        //{
            //return $"{LastName} {FirstName} {PatronymicName}";
        //}

        public bool IsAdmin()
        {
            return UserRole == 1;
        }

        public bool IsManager()
        {
            return UserRole == 2;
        }

        internal bool IsClient()
        {
            return UserRole == 3;
        }

        // } STUD

    }
}
