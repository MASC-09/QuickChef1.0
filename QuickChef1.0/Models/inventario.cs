using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuickChef1._0.Models
{
    public class inventario
    {
        [Key]
        public string productoID { get; set; }

        public string nombreProducto { get; set; }

        public int cantidadProducto { get; set; }

    }

    public class InventarioContext : DbContext
    {
        public DbSet<inventario> inventarios { get; set; }
    }
}           