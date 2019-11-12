using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Entity.Spatial;
using System.Configuration;
using System.Linq;
using System.Web;

namespace QuickChef1._0.Models
{
    public class admin
    {

        [Required(ErrorMessage = "Por favor, ingrese su usuario.")]
        [Display(Name = "Usuario : ")]
        public string adminID { get; set; }

        

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Por favor, ingrese su contraseña.")]
        [Display(Name = "Password : ")]
        public string passwordAdmin { get; set; }

        public string UserName { get; set; }
        //[StringLength(20)]
        //public string adminID { get; set; }

        //[StringLength(20)]
        //public string passwordAdmin { get; set; }

        //This method validates the Login credentials
        public String LoginProcess(String strUsername, String strPassword)
        {
            String message = "";
            //my connection string
            //note> in the connection string this (/*where UserId=@Username*/) was removed after the name of the table.
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginContext"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from admins WHERE adminID='" + strUsername + "' AND passwordAdmin='" + strPassword + "'", con);
            cmd.Parameters.AddWithValue("@Username", strUsername);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Boolean login = (strPassword.Equals(reader["passwordAdmin"].ToString(), StringComparison.InvariantCulture)) ? true : false;
                    if (login)
                    {
                        message = "1";
                        //UserName = reader["UserName"].ToString();
                        

                    }
                    else
                        message = "Invalid Credentials";
                }
                else
                    message = "Invalid Credentials";

                reader.Close();
                reader.Dispose();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                message = ex.Message.ToString() + "Error.";

            }
            return message;
        }

    }
}



   /*

    public class AdminContext : DbContext
 {
        public AdminContext()
            : base("name=LoginContext")
        {
        }
        */
   // { public DbSet<admin> admins { get; set; } }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.adminID)
                .IsUnicode(false);

            modelBuilder.Entity<admin>()
                .Property(e => e.passwordAdmin)
                .IsUnicode(false);
        }*/
    
