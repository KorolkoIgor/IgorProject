using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock mclock = new Clock(true);
            mclock.Tick();

            Clock eclock = new Clock(false);
            eclock.Tick();

            Console.Read();
        }
    }
}
