using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Laserlab;
using Laserlab.Data.Model;

namespace Laserlab.Data.Access
{

    public class LaserlabContext : DbContext
    {
        private DbModelBuilder _modelBuilder;
        public LaserlabContext() : base("LaserlabContext")
        {
            _modelBuilder = new DbModelBuilder();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<PersonTypes> PersonTypes { get; set; }
    }
}

