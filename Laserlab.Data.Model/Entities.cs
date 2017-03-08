using Abstraction.Laserlab;
using Abstraction.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace Laserlab.Data.Model
{
    public class Person : IPerson
    {
       
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Title { get; set; }
        
        public int Id { get; set; }
        public PersonTypes PersonType { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
    public class PersonTypes 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Document : IDocument
    {
        public string Extension { get; set; }
        public string Path { get; set; }     
        public int Id { get; set; }
        public Person Owner { get; set; }
    }
}
//todo