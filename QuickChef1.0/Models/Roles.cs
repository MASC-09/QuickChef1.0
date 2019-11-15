using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity.Spatial;
using System.Data.Entity;

namespace QuickChef1._0.Models
{
    public class roles
    {
        [Key]
            
        public string rol { get; set; }

        public string menu1 { get; set; }

        public string menu2 { get; set; }
        public string menu3 { get; set; }
        public string opcE { get; set; }
        public string opcB { get; set; }
        public string opcD { get; set; }

    }
    public class rolesContext : DbContext
    {
        public DbSet<roles> roles { get; set; }
    }
}