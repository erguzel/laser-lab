using Abstraction.Core;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// To configure and design navigation relation as a templete
/// </summary>
namespace Abstraction.Laserlab
{
    public interface IUserTypes: Ibeidentifiable, IbeDescriptable //admin, member, guest
    {
       ICollection<IUser> Users { get; set; }
    }
   public interface IUser: Ibeidentifiable,IbeNamable
    {
        ICollection<IProject> Projects { get; set; }
        IUserTypes UserType { get; set; }
    }
    public interface IProject:IbeTitlable, IDuable, Ibeidentifiable
    {
        ICollection<IUser> Users { get; set; }
    }
}
