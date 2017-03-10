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
            UserType t1 = new UserType() { Id = 1, Description = "Admin" };
            UserType t2 = new UserType() { Id = 1, Description = "Member" };
            UserType t3 = new UserType() { Id = 1, Description = "Guest" };
            List<UserType> userTypes = new List<UserType>();
            userTypes.Add(t1);
            userTypes.Add(t2);
            userTypes.Add(t3);
            Laserlab.Service.LaserlabService<UserType> userService = new Service.LaserlabService<UserType>();
            userService.InsertRange((IEnumerable<UserType>)userTypes);
        }
    }
}
