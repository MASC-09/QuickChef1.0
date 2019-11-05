namespace QuickChef1._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.Entity;

    
    public class menu
    {
        [Key]
        [StringLength(20)]
        public string platilloID { get; set; }

        [StringLength(30)]
        public string nombrePlatillo { get; set; }

        [StringLength(100)]
        public string descripcionPlatillo { get; set; }

        public int? porcionesPlatillo { get; set; }

        public int? precioPlatillo { get; set; }
    }

    public class MenuContext : DbContext
    {
        public DbSet<menu> menus { get; set; }
    }
}
