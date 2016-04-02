using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger
    {
        public virtual void Error(string error)
        {
            Console.WriteLine("1__0");
        }
        public virtual void Warning(string warning)
        {
            Console.WriteLine("1__0");
        }
    }
}
