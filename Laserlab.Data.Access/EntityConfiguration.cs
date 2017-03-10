using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laserlab.Model;
using Abstraction.Core;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laserlab.Data.Access
{

    public class UserConfig : EntityTypeConfiguration<User>
    {

    }
    public class UserTypeConfig : EntityTypeConfiguration<UserType>
    {
        public UserTypeConfig()
        {
            this.HasKey(a => a.Id);
            this.HasMany(m => m.Users).WithRequired();
            this.Property(p => p.Name).HasColumnType("nvarchar").HasMaxLength(30);
            this.Property(p => p.Name).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UQ_UserTypeName", 1) { IsUnique = true }));
          
        }
    }
    public class UserTypeConfiguration: ComplexTypeConfiguration<UserType>
    {
        public UserTypeConfiguration()
        {

            this.Property(p => p.Name).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            this.Property(p => p.Name).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UQ_UserTypeName", 1) { IsUnique = true }));
        }
    }
    
}
