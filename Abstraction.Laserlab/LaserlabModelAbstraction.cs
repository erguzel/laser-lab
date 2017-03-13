using Abstraction.Core;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// To configure and design navigation relation as a templete
/// </summary>
namespace Abstraction.Laserlab
{
    public interface IPerson: IUniqueIdentifier, IBeNamable, IbeSurnamable, IBornable, IGenderable, IMiddleName
    {
        // nav person typess
        // nav documentss
        // nav phones
        // nav emails
        // nav publications
        // nav users
    }
    public interface IPersonType :IEnumic // user, collaborator, admin, visitor
    {
        // nav personss
    }
    public interface IAuthorization:IUniqueIdentifier, IUserName, IPassword
    {
        // nav user
    }
    public interface IUser: IUniqueIdentifier
    {
        // nav user types
        // nav authorization
        //nav person
    }
    public interface IUserType: IEnumic //admin, user, visitor
    {
        //nav users
    }
    public interface IDocument : IUniqueIdentifier, IPathable
    {
        // nav personss
        // nav doctypess
        // topics
        //nav extension
    }
    public interface IExtensionType:IEnumic //img,png,doc...
    {
        // nav documents
    }

    public interface IDocumentType: IEnumic // maintenance, personal, temporary, social, technical, IAcademic
    {
        // nav documentss
        
    }
    public interface IPublication:IUniqueIdentifier, IbeTitlable, IYear
    {
        //nav personss
    }
    public interface ITopic:IUniqueIdentifier, IbeTitlable, IParagraph
    {
        // nav documentss
    }
    public interface IFacility: IEnumic,IDetailable, IRulable //
    {
        //nav documentsss
        // nav Equipments
    }
    public interface IEquipmentType:IEnumic//synthesis, characterization, fabrication, sterilization
    {
        //nav equipmentss
    }
    public interface IEquipment: IEnumic, IbeDescriptable, IModelable, ICountable, IChronological
    {
        // nav equipment type
        //nav documents
        //nav facility
    }
    public interface IChemicalType: IEnumic//acit, base, salt, nitrite, nitrate, polymer, silicate
    {
        // nav chemicals
    }
    public interface IChemical: IEnumic, IChemicalFormula, IPhase, IColorable, IAmount
    {
        // nav chemical type
    }
    public interface IEmail:IUniqueIdentifier, IeMail, ICheckPrimary
    {
        //person
    }
    public interface IPhone : IbePhonable
    {
        //person
    }
}
