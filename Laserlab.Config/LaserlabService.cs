using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Laserlab.Config
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class LaserlabService : ILaserlabService
    {
        public string DoWork(string message)
        {
            return "This is From The service : " + message;
        }
    }
}
