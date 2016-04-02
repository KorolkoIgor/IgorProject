using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class DBLogger:Logger
    {
        public override void Error(string error)
        {
            Console.WriteLine(DateTime.Now.ToString() + "This is error for database logger" + error);
        }
        public override void Warning(string warning)
        {
            Console.WriteLine(DateTime.Now.ToString() + "This is warning for database logger " + warning);
        }
    }
}
