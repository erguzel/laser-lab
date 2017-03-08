using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laserlab.Data.Model;

namespace Laserlab.Data.Access
{
    class UserConfiguration : EntityTypeConfiguration<Person>
    {
        public UserConfiguration()
        {
            //todo
            this.HasKey(a => a.Id);
        }
    }
    class DocumentConfiguration: EntityTypeConfiguration<Document>
    {
        public DocumentConfiguration()
        {
            //todo
            this.HasKey(a => a.Id);

        }

    }
    class PeronTypeConfiguration : EntityTypeConfiguration<PersonTypes>
    {
        public PeronTypeConfiguration()
        {
        }
    }
    //todo
}
