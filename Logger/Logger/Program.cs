using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting = ConfigurationManager.AppSettings["Logger"];
            var currentLogger = LoggerFactory.FactoryMethod(setting);
            Console.Read();
        }
    }
}
