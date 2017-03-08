using Laserlab.Data.Model;
using Laserlab.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laserlab.Mapper
{
    public static class LaserlabMapper
    {
        public static Person MapToServerObject(PersonDTO uiPerson)
        {
            return new Person() { Name = uiPerson.Name, SurName = uiPerson.SurName, Title = uiPerson.Title };
        }
    }
}
//todo