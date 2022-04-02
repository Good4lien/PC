using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    class motherboard
    {
        string name = "motherboard 90000     ok!";
        
        public void start()
        {
            Console.WriteLine(name);
            CPU CPU1;
            CPU1 = new CPU();
            CPU1.startcpu();

            GPU GPU1 = new GPU();
            GPU1.startgpu();

            hdd RAID = new hdd();
            RAID.starthdd();

            ssd intel1 = new ssd();
            intel1.Startssd();

            monitor LG7 = new monitor();
            LG7.StartMonitor();

        }
    }
}
