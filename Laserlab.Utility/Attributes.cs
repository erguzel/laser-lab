using Abstraction.Core;
using System;

namespace Laserlab.Utility
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKeyAttribute : Attribute, ITable
    {
        public string Schema { get; set; }
        public string Table { get; set; }
        public string ColumnType { get; set; }
        public string ColumnName { get; set; }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class ForeignKeyAttribute : Attribute, ITable
    {
        public string Schema { get; set; }
        public string Table { get; set ; }
        public string ColumnType { get ; set ; }
        public string ColumnName { get ; set ; }
    }
}
