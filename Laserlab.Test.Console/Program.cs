using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Abstraction.Laserlab;
using Laserlab.Model;

namespace Laserlab.Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonType p1 = new PersonType()
            {
                Name = "Admin"

            };
            PersonType p2 = new PersonType()
            {
                Name = "User"

            };
            PersonType p3 = new PersonType()
            {
                Name = "Visitor"

            };
            List<PersonType> ps = new List<PersonType>();
            ps.Add(p1);
            ps.Add(p2);
            ps.Add(p2);
            using (Laserlab.Service.LaserlabService<PersonType> _pt = new Service.LaserlabService<PersonType>())
            {
                _pt.InsertRange(ps);
            }

        }
    }
}
