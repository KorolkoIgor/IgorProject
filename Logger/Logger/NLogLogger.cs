using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class NLogLogger:Logger
    {
        public override void Error()
        {
            Console.WriteLine("2__0");
        }
        public override void Worning()
        {
            Console.WriteLine("2__0");
        }
    }
}
