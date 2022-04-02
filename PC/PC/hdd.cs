using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    class hdd
    {
        public void starthdd() 
        {
            hdd d1, d2;

            d1 = new hdd();
            d2 = new hdd();

            d1.hdd1();
            d2.hdd2();
        }

        public void hdd1() 
        {
            Console.WriteLine("hdd toshiba-1000      ok!");
        }
        public void hdd2()
        {
            Console.WriteLine("hdd-2 WD-500          ok!");
            
        }

    }
}
