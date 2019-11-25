﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuickChef1._0.Models
{
    public class Encuesta
    {
        public string EncuestaID { get; set; }
        public string NumMesa { get; set; }
        public string Puntuacion { get; set; }
    }
    public class EncuestaContext : DbContext
    {
        public DbSet<Encuesta> encuestas { get; set; }
    }
}