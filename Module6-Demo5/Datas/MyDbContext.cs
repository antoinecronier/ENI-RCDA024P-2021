using Module6_Demo5.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Demo5.Datas
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Personne> Personnes { get; set; }
    }
}
