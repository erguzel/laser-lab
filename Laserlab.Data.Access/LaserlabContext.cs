using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Laserlab;
using Laserlab.Model;
using System.Data.Entity.ModelConfiguration;


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
          
            //modelBuilder.Configurations.Add(new UserTypeConfig());
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Project> Project { get; set; }
    }
}

