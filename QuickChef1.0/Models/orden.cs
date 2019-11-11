namespace QuickChef1._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.Entity;


    public class orden
    {
        [Key]
        public int? relativo { get; set; }

        public int? Mesa { get; set; }

        
        public string platilloID { get; set; }

        public int? cantidad { get; set; }

        
    }

    public class ordenContext : DbContext
    {
        public DbSet<orden> orden { get; set; }
    }
}
