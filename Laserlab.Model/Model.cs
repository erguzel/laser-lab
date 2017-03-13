using Abstraction.Laserlab;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Abstraction.Core;
using System.Threading.Tasks;

namespace Laserlab.Model
{
    public class Person : IPerson
    {

        #region navs
        public ICollection<PersonType> PersonTypes { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public ICollection<Email> eMails { get; set; }
        public ICollection<Publication> Publications { get; set; }
        public ICollection<User> Users { get; set; }
        //
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsFemale { get; set; }
        public string MiddleName { get; set; }
        #endregion
    }
    public class PersonType : IPersonType
    {
        #region navs
        public ICollection<Person> Persons { get; set; }
        //
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
    public class Authorization : IAuthorization
    {
        #region navs
        public ICollection<User> Users { get; set; }
        //
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        #endregion
    }
    public class User : IUser
    {
        #region navs
        public ICollection<UserType> UserTypes { get; set; }
        public Authorization Authorization { get; set; }
        public Person Person { get; set; }
        //
        public int Id { get; set; }
        #endregion
    }
    public class UserType : IUserType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        #region navs
        ICollection<User> Users { get; set; }
        //
        #endregion
    }
    public class ExtensionType : IExtensionType
    {
        #region navs
        public ICollection<Document> Documents { get; set; }
        //
        public int Id { get; set; }
        public string Name { get; set; }
        //
        #endregion
    }
    public class Document : IDocument
    {
        #region navs
        public ICollection<Person> Persons { get; set; }
        public ICollection<DocumentType> DocumentTypes { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
        public ExtensionType Extension { get; set; }
        //
        public int Id { get; set; }
        public string Path { get; set; }
        #endregion
    }
    public class DocumentType : IDocumentType
    {
        #region navs
        public ICollection<Document> Documents { get; set; }
        //
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
    public class Publication : IPublication
    {
        #region nav
        public ICollection<Person> Persons { get; set; }
        //
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        #endregion
    }
    public class Topic : ITopic
    {

        #region navs
        public ICollection<Document> Documents { get; set; }
        //
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        #endregion
    }
    public class Facility : IFacility
    {
        #region navs
        public  ICollection<Document> Documents { get; set; }
        public  ICollection<Equipment> Equipments { get; set; }
        //
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Ruler { get; set; }
        #endregion
    }
    public class EquipmentType:IEquipmentType
    {
        #region nav
        public  ICollection<Equipment> Equipments { get; set; }
        //
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
    public class Equipment:IEquipment
    {
        #region navs
        //public  ICollection<EquipmentType> EquipmentTypes { get; set; }
        public  ICollection<Document> Documents { get; set; }
        public  Facility Facility { get; set; }
        //
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ModelCode { get; set; }
        public double Count { get; set; }
        public DateTime TheDate { get; set; }
        //
        #endregion
    }
    public class ChemicalType:IChemicalType
    {
        #region navs
        public  ICollection<Chemical> Chemicals { get; set; }
        //
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
    public class Chemical : IChemical
    {
        #region navs
        public  ChemicalType ChemicalType { get; set; }
        //
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChemicalFormula { get; set; }
        public string Phase { get; set; }
        public string ColorCode { get; set; }
        public double Amount_gr { get; set; }

        //
        #endregion
    }
    public class Email:IEmail
    {
        #region MyRegion
        public  ICollection<Person> Persons { get; set; }
        //
        public int Id { get; set; }
        public string eMail { get; set; }
        public bool IsPrimary { get; set; }
        #endregion
    }
    public class Phone:IPhone, IUniqueIdentifier
    {
        #region nav
        public  ICollection<Person> Persons { get; set; }
        //
        public long PhoneNo { get; set; }
        public int Id { get; set; }
        #endregion
    }
}
