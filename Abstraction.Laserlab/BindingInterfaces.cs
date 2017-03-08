using Abstraction.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Laserlab
{
    public interface IUniversity : IbeNamable, Ibeidentifiable
    {

    }
    public interface IPerson : IbeNamable, IbeSurnamable, IbeTitlable
    {
   
    }
    public interface IPersonTypes : Ibeidentifiable, IBeNamable
    {

    }
    /// <summary>
    /// img png files
    /// </summary>
    public interface IPicture : IFile
    {

    }
    public interface IDocument : IFile, Ibeidentifiable
    {

    }
    public interface IGroupMember : IPerson
    {


    }
    public interface ITopic : IbeDescriptable, IDetailable, IPicturable, IDocumentable
    {

    }
    public interface ICollaborator : IPerson
    {
        IUniversity University { get; set; }
    }
    public interface IFile : IFileExtension, IPathable
    {

    }
    public interface IFacility : IbeNamable, Ibeidentifiable, IbeDescriptable
    {

    }
    public interface IEquipment : IbeNamable, IModelable, Ibeidentifiable, IPicturable
    {

    }
    public interface IFurnace : IEquipment
    {
        string MaximumTemperature { get; set; }
    }
    public interface IPublication : IbeTitlable, IAbstractable, Ibeidentifiable, IUrl
    {

    }
}
