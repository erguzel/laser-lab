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
            //this.Database.Delete();
            _modelBuilder = new DbModelBuilder();
            OnModelCreating(_modelBuilder);
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserTypeConfig());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Project> Project { get; set; }
    }
    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
    //     .Where(type => !String.IsNullOrEmpty(type.Namespace))
    //     .Where(type => type.BaseType != null && type.BaseType.IsGenericType
    //          && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
    //    foreach (var type in typesToRegister)
    //    {
    //        dynamic configurationInstance = Activator.CreateInstance(type);
    //        modelBuilder.Configurations.Add(configurationInstance);
    //    }
    //    base.OnModelCreating(modelBuilder);
    //}
}

