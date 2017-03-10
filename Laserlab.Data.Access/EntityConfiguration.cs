using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laserlab.Data.Model;
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
            this.Property(p => p.Description).HasColumnType("NVARCHAR(20").HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UQ_UserTypeDescription", 2)));
        }
    }
    
}
