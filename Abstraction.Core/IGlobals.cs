using System;
using System.Collections.Generic;

namespace Abstraction.Core
{
    /// <summary>
    /// Anything
    /// </summary>
    public interface IUniqueIdentifier
    {
        int Id { get; set; }
    }
    /// <summary>
    /// Anything that has a name
    /// </summary>
    public interface IbeNamable
    {
        string Name { get; set; }
    }
    /// <summary>
    /// Any person that has a surname
    /// </summary>
    public interface IbeSurnamable
    {
        string SurName { get; set; }
    }
    /// <summary>
    /// Anything that has a status
    /// </summary>
    public interface IbeTitlable
    {
        string Title { get; set; }
    }
    /// <summary>
    /// any object that has email property
    /// </summary>
    public interface IbeMailable
    {
        IEnumerable<string> eMails { get; set; }
    }
    /// <summary>
    /// Anything that has a phone number property
    /// </summary>
    public interface IbePhonable
    {
        IEnumerable<int> PhoneNumbers { get; set; }
    }
    /// <summary>
    /// Any object that has status property
    /// </summary>
    public interface IbePerturbative
    {
        string status { get; set; }
    }


}