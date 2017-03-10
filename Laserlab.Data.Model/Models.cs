using Abstraction.Core;
using Abstraction.Laserlab;
using System.Collections.Generic;
using System;

namespace Laserlab.Data.Model
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
        public string Description { get; set; }
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
//todo