using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Data.Service.Config
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DataDynammic : IDataDynammic
    {
        public string DoWork(string message)
        {
            return "This is From The service : " + message;
        }
    }
}
