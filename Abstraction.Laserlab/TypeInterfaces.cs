using System;
using Abstraction.Core;
using System.Collections;
using System.Collections.Generic;

namespace Abstraction.Laserlab
{
    public interface IPicturable 
    {
        IEnumerable<IPicture> Pictures { get; set; }
    }
    public interface IDocumentable
    {
        IEnumerable<IDocument> Documents { get; set; }
    }
    public interface IUniversity:IbeNamable, Ibeidentifiable
    {

    }
    public interface IPerson:IbeNamable,IbeSurnamable,IbeTitlable
    {
        IEnumerable<IDocument> Documents { get; set; }

    }
    /// <summary>
    /// img png files
    /// </summary>
    public interface IPicture:IFile
    {

    }
    public interface IDocument:IFile
    {

    }
    public interface IGroupMember:IPerson
    {
     

    }
    public interface ITopic:IbeDescriptable, IDetailable, IPicturable, IDocumentable
    {
        
    }
    public interface ICollaborator:IPerson
    {
        IUniversity University { get; set; }
    }
    public interface IFile:IFileExtension, IPathable
    {

    }
    public interface IFacility:IbeNamable, Ibeidentifiable, IbeDescriptable
    {

    }
    public interface IEquipment: IbeNamable, IModelable,Ibeidentifiable, IPicturable
    {

    }
    public interface IFurnace: IEquipment
    {
        string MaximumTemperature { get; set; }
    }
    public interface ILuminescence
    {

    }
    public interface IPublication:IbeTitlable, IAbstractable, Ibeidentifiable, IUrl
    {

    }
}
