using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Clock
    {
        public bool IsMechanic { get; set; }

        public Clock(bool isMechanic)
        {
            IsMechanic = isMechanic;
        }
        public void Tick()
        {
            for(int i=0;i<60;i++)
            {
                if(IsMechanic)
                {
                    if (i % 10 == 0)
                        Console.WriteLine("Machanic tick" + i);
                }
                else
                {
                    if (i % 3 == 0)
                        Console.WriteLine("Electronic tick" + i);

                }
            }
        }

    }
}
