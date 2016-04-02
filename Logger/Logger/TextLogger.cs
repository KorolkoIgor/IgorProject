using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class TextLogger:Logger
    {
        public override void Error(string error)
        {
            Console.WriteLine(DateTime.Now.ToString() + "This is error for text file logger" + error);
        }
        public override void Warning(string warning)
        {
            Console.WriteLine(DateTime.Now.ToString() + "This is warning for text file logger " + warning);
        }
        
    }
}
