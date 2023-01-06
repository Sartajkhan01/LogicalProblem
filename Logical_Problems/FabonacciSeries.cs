using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{

    public class StopWatchProblem
    {
        public void StopWatch()
        {
            Console.WriteLine("press Enter to start");
            Console.ReadLine();
            DateTime Start = DateTime.Now;

            Console.WriteLine("press Enter to stop.");
            Console.ReadLine();
            DateTime Stop = DateTime.Now;

            Console.WriteLine("Elapsed Time =" + (Stop - Start));
        }
    }
}
