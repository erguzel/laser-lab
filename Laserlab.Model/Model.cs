using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laserlab.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //nav
        public UserType UserType { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
    public class UserType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // nav
        public ICollection<User> Users { get; set; }
    }
    public class Project
    {
        public ICollection<User> Users { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Id { get; set; }
    }
}
