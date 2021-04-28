using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Module6_Tp1_ASP.Data
{
    public class Module6_Tp1_ASPContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Module6_Tp1_ASPContext() : base("name=Module6_Tp1_ASPContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Module6_Tp1_BO.Entities.Samourai>().HasOptional(x => x.Arme).WithOptionalPrincipal();
            modelBuilder.Entity<Module6_Tp1_BO.Entities.Samourai>().HasMany(x => x.ArtMartiaux).WithMany();
        }

        public System.Data.Entity.DbSet<Module6_Tp1_BO.Entities.Arme> Armes { get; set; }
        public System.Data.Entity.DbSet<Module6_Tp1_BO.Entities.Samourai> Samourais { get; set; }
        public System.Data.Entity.DbSet<Module6_Tp1_BO.Entities.ArtMartial> ArtMartiaux { get; set; }
    }
}
