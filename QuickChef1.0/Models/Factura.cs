using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuickChef1._0.Models
{
    public class Factura
    {
        [Key]
        public int? relativo { get; set; }

        public int? Mesa { get; set; }


        public string platilloID { get; set; }

        public int? cantidad { get; set; }

        public int? precio { get; set; }
        public string EstadoOrden { get; set; }
    }

    public class FacturaContext : DbContext
    {
        public DbSet<Factura> Factura { get; set; }
    }
}