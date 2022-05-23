using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class MaxString
    {
        public static String ToPrint1(String str1, String str2,String str3)
        {
            if (str1.CompareTo(str2) > 0 && str1.CompareTo(str3) > 0 || str1.CompareTo(str2) >= 0 && str1.CompareTo(str3) > 0 || str1.CompareTo(str2) > 0 && str1.CompareTo(str3) >= 0)
            {
                Console.WriteLine(str1 + " is Greter Name");
                return str1;
            }
            else if (str2.CompareTo(str1) > 0 && str2.CompareTo(str3) > 0 || str2.CompareTo(str1) >= 0 && str2.CompareTo(str3) > 0 || str2.CompareTo(str1) > 0 && str2.CompareTo(str3) >= 0)
            {
                Console.WriteLine(str2 + " is Greter Name");
                return str2;
            }
            else
            {
                Console.WriteLine(str3 + " is Greter Name");
                return str3;
            }
            
        }

    }
}
