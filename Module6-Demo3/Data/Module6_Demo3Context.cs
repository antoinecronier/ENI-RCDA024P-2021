using Module6_Demo3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Module6_Demo3.Data
{
    public class Module6_Demo3Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Module6_Demo3Context() : base("name=Module6_Demo3Context")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //System.Data.Entity.ModelConfiguration.Conventions.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Album>().Ignore(x => x.NombreDePiste);
            modelBuilder.Entity<Album>().HasMany(x => x.Pistes).WithRequired();
            modelBuilder.Entity<Album>().HasMany(x => x.Artistes).WithMany();
        }

        public System.Data.Entity.DbSet<Module6_Demo3.Models.Album> Albums { get; set; }
        public System.Data.Entity.DbSet<Module6_Demo3.Models.Artiste> Artistes { get; set; }
    }
}
