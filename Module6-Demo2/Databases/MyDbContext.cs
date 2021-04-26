using Module6_Demo2.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Demo2.Databases
{
    public class MyDbContext : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Adresse> Adresses { get; set; }

    }
}
