using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

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
	public interface IGettableAll
	{
		IEnumerable<Entity> GetAll<Entity>() where Entity : class;
	}
	public interface IGettableWhere
	{
		 /// <summary>
        /// Gets by condition
        /// </summary>
        /// <typeparam name="Entity"></typeparam>
        /// <param name="entityPredicate"></param>
        /// <returns></returns>
        IEnumerable<Entity> GetBy<Entity>(Expression<Func<Entity, bool>> condition) where Entity : class;
	}
	 public interface IChangable : IChronological
    {
        string PreviousState { get; set; }
        string CurrentState { get; set; }
    }
    /// <summary>
    /// Anythig which is definable by a client or a customer.
    /// </summary>
    public interface IClientDefined : IChronological
    {
        string Definer { get; set; }
    }
    /// <summary>
    /// Anything that has to do with date.
    /// </summary>
    public interface IChronological
    {
        DateTime TheDate { get; set; }
    }
    /// <summary>
    /// Anything has a name
    /// </summary>
    public interface IBeNamable
    {
        string Name { get; set; }
    }
    /// <summary>
    /// Any kind of information that a bit processing device can recognize.
    /// </summary>
    public interface IBitRepresentation
    {
        string DataType { get; set; }
    }
    /// <summary>
    /// Anything that has a max and min value.
    /// </summary>
    public interface IExtremum
    {
        string MinValue { get; set; }
        string MaxValue { get; set; }
    }
    /// <summary>
    /// Anything that has default value.
    /// </summary>
    public interface IConjecturableValue
    {
        string DefaultValue { get; set; }
    }
    /// <summary>
    /// Anything that can be represented by an id.
    /// </summary>
    public interface Ibeidentifiable
    {
        int Id { get; set; }
    }
    /// <summary>
    /// Anything that needs description.
    /// </summary>
    public interface IbeDescriptable
    {
        string Description { get; set; }
    }
    /// <summary>
    /// Anything that is countable
    /// </summary>
    public interface ICountable
    {
        double Quantity { get; set; }
    }
    /// <summary>
    /// Anything that is profitable
    /// </summary>
    public interface IProfitable
    {
        double Profit { get; set; }
    }
    /// <summary>
    /// Anything that has a source, mainly data
    /// </summary>
    public interface ISourcable
    {
        /// <summary>
        /// Represents the db object where the data is coming from
        /// </summary>
        string source { get; set; }
    }
    /// <summary>
    /// Anything that has a inpacting effect
    /// </summary>
    public interface IEffectable
    {
        double Effect { get; set; }
    }
    /// <summary>
    /// Anything that can be sold
    /// </summary>
    public interface ISaleble
    {
        double Price { get; set; }
    }
    /// <summary>
    /// Any place
    /// </summary>
    public interface ILocatable
    {
        string Location { get; set; }
    }
    /// <summary>
    /// Anything that has a model
    /// </summary>
    public interface IModelable
    {
        string ModelCode { get; set; }
    }
    /// <summary>
    /// Anything that has a color
    /// </summary>
    public interface IColorable
    {
        string ColorCode { get; set; }
    }
    /// <summary>
    /// Anything sizable
    /// </summary>
    public interface ISizable
    {
        string SizeCode { get; set; }
    }
    /// <summary>
    /// Anything depends on season
    /// </summary>
    public interface ISeasonable
    {
        string SeasonCode { get; set; }
    }
    /// <summary>
    /// Represents any object that has an item code
    /// </summary>
    public interface IMerchandize
    {
        string ItemCode { get; set; }
    }
    /// <summary>
    /// Represents any place that has store code
    /// </summary>
    public interface IShop
    {
        string StoreCode { get; set; }
    }
    /// <summary>
    /// Any object representable by iso week number
    /// </summary>
    public interface IWeekly
    {
        int WeekOfYear { get; set; }
    }
    /// <summary>
    /// Any object representable iso day number
    /// </summary>
    public interface IDaily
    {
        int DayOfYear { get; set; }
    }
    /// <summary>
    /// Anything that has a value, such as paramater or variable etc.
    /// </summary>
    public interface IValuable
    {
        string value { get; set; }
    }
    /// <summary>
    /// Anything that can be represented by standard deviation 
    /// </summary>
    public interface IDeviatable
    {
        double Sigma { get; set; }
    }
    /// <summary>
    /// Anything that can be represented by mean value
    /// </summary>
    public interface IMeanable
    {
        double Mu { get; set; }
    }
    public interface IFileExtension
    {
        string Extension { get; set; }
    }
    public interface IPathable
    {
        string Path { get; set; }
    }
    public interface IDetailable
    {
        string Detail { get; set; }
    }
    /// <summary>
    /// Abstract of a publication
    /// </summary>
    public interface IAbstractable
    {
        string Abstract { get; set; }
    }
    public interface IUrl
    {
        string Url { get; set; }
    }
    public interface ITable
    {
         string Schema { get; set; }
         string Table { get; set; }
         string ColumnType { get; set; }
         string ColumnName { get; set; }
    }
    public interface IService<entity> where entity:class
    {
        IEnumerable<entity> GetAll();
        IEnumerable<entity> GetBy(Expression<Func<entity, bool>> entityPredicate);
        entity Find(Expression<Func<entity, bool>> entityPredicate);
        bool Insert(entity entity);
        bool Delete(entity entity);
        bool InsertRange(IEnumerable<entity> entityRange);
        bool DeleteRange(IEnumerable<entity> entityRange);
        bool InjectTSQL(StringBuilder command, object[] parameters);
        bool InjectTSQL(string command);
    }
}