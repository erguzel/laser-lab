﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Laserlab.Host
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(Laserlab.Config.LaserlabService)))
            {

                try
                {
                    host.Open();
                    Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Service won't start! Host authorization required :" + DateTime.Now.ToString());
                    Console.WriteLine("Use commandline to start service from server");
                    Console.ReadLine();
                    //System.ServiceModel.AddressAccessDeniedException
                }
            }
        }
    }
}
