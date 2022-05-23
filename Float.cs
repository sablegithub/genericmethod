using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Float
    {
        public static double ToPrint2(double flot1,double flot2,double flot3)
        {
            if (flot1.CompareTo(flot2) > 0 && flot1.CompareTo(flot3) > 0 || flot1.CompareTo(flot2) >= 0 && flot1.CompareTo(flot3) > 0 || flot1.CompareTo(flot2) > 0 && flot1.CompareTo(flot3) >= 0)
            {
                Console.WriteLine(flot1 + " is Greteest");
                return flot1;
            }
            else if (flot2.CompareTo(flot1) > 0 && flot2.CompareTo(flot3) > 0 || flot2.CompareTo(flot1) >= 0 && flot2.CompareTo(flot3) > 0 || flot2.CompareTo(flot1) > 0 && flot2.CompareTo(flot3) >= 0)
            {
                Console.WriteLine(flot2 + " is Gretest");
                return flot2;
            }
            else
            {
                Console.WriteLine(flot3 + " is Greteest");
            }
            return flot3;
        }
    }
}
