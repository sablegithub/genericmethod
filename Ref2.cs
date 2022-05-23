using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Ref2
    {
        public  static T Print <T>(T num1, T num2,T num3) where T : IComparable
            {


            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                Console.WriteLine(num1 + " is Gretest ");
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                Console.WriteLine(num2 + " is Gretest ");
                return num2;
            }
            else
            {
                Console.WriteLine(num3 + " is Gretest");
                return num3;
            }

        }
    }
}
