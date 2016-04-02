using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class LoggerFactory
    {
        public static Logger FactoryMethod(string loggerType)
        {
            Logger logger = new Logger();
            switch(loggerType)
            {
                case"console":
                    logger = new ConsoleLogger();
                    break;
                case "text":
                    logger = new TextLogger();
                    break;
                case "db":
                    logger = new DBLogger();
                    break;
                default:
                    logger = new ConsoleLogger();
                    break;

            }
            return logger;
        }
    }
}
