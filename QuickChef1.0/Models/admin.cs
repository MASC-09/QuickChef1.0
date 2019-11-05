namespace QuickChef1._0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;

    public class admin
    {
        [StringLength(20)]
        public string adminID { get; set; }

        [StringLength(20)]
        public string passwordAdmin { get; set; }
    }

    public class AdminContext : DbContext
    /*{
        public AdminContext()
            : base("name=LoginContext")
        {
        }
        */
    { public DbSet<admin> admins { get; set; } }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.adminID)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.passwordAdmin)
                .IsUnicode(false);
        }*/
    }
