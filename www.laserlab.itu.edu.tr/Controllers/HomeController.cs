using Laserlab.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace www.laserlab.itu.edu.tr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (Laserlab.Service.LaserlabService<PersonTypes> ps = new Laserlab.Service.LaserlabService<PersonTypes>())
            {
                PersonTypes ps1 = new PersonTypes() { Id = 1, Name = "GroupMember" };
                PersonTypes ps2 = new PersonTypes() { Id = 2, Name = "Collaborator" };
                PersonTypes ps3 = new PersonTypes() { Id = 3, Name = "Student" };

                List<PersonTypes> persons = new List<PersonTypes>();
                persons.Add(ps1);
                persons.Add(ps2);
                persons.Add(ps3);
                ps.InsertRange(persons);
            }

            return View();
        }

        public ActionResult About()
        {
            using (Laserlab.Service.LaserlabService<Person> personService = new Laserlab.Service.LaserlabService<Person>())
            {
                Person p = personService.Find(per => per.Id == 253);
            }
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}