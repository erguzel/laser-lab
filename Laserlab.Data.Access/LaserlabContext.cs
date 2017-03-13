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
            //OnModelCreating(_modelBuilder);
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new UserTypeConfig());
            base.OnModelCreating(modelBuilder);
        }
        public  DbSet<Person> Person { get; set; }
        public  DbSet<PersonType> PersonTypes { get; set; }
        public  DbSet<Authorization> Authorizations { get; set; }
        public  DbSet<User> Users { get; set; }
        public  DbSet<ExtensionType> ExtensionTypes { get; set; }
        public  DbSet<Document> Documents { get; set; }
        public  DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Facility> Facilitys { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<ChemicalType> ChemicalTypes { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Phone> Phones { get; set; }


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

