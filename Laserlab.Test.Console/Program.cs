using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Abstraction.Laserlab;
using Laserlab.Data.Model;

namespace Laserlab.Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonTypes ps1 = new PersonTypes() { Id = 1, Name = "GroupMember" };
            PersonTypes ps2 = new PersonTypes() { Id = 2, Name = "Collaborator" };
            PersonTypes ps3 = new PersonTypes() { Id = 3, Name = "Student" };

            List<PersonTypes> persons = new List<PersonTypes>();
            persons.Add(ps1);
            persons.Add(ps2);
            persons.Add(ps3);
            using (Laserlab.Service.LaserlabService<PersonTypes> sev = new Service.LaserlabService<PersonTypes>())
            {
               bool isOk =  sev.InsertRange(persons);
                
            }
            
        }
    }
}
