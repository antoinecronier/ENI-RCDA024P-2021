using Module6_Demo1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Demo1.Databases
{
    public class MyDbContext : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
