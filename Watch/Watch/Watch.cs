using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch
{
    public class Watch
    {
         public Watch (bool type)
        { 
            IsMechanic = type;
        }

        public bool  _type;
        public int result
        {
        get {return minuta; }
            set{  minuta = value;}
        }
        public bool IsMechanic
        {
            get { return _type; }

            set
            {
                _type = value;}
               
            }
         }
       public int Emulation_Watch(int minuta) 
     {
    for (int k = minuta; k <= 60; k++)
     {
    result +=1;
    
    return result;
    Concole.Writline(result);
     }
     }
    }

    
