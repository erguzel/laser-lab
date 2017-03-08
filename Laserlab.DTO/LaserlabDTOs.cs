using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction.Core;
using Abstraction.Laserlab;

/// <summary>
/// UI can have access to model layer, no need yet
/// </summary>
namespace Laserlab.DTO // todo
{
    public class PersonDTO : IPerson
    {
        public IEnumerable<IDocument> Documents { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Title { get; set; }
    }
    public class DocumentDTO : IDocument
    {
        public string Extension { get; set; }
        public string Path { get; set; }
        public int Id { get; set; }
    }
    public class PersonTypesDTO : IPersonTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
