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
    public class EquipmentDTO : IEquipment
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ModelCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Count { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime TheDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
