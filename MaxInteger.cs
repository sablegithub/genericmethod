namespace Generic
{
    public class MaxInteger
    {
        public static int ToPrint(int num1, int num2, int num3)

        {

            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                Console.WriteLine(num1 + " is Greter number");
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                Console.WriteLine(num2 + " is Greter number");
                return num2;
            }
            else
            {
                Console.WriteLine(num3 + " is Greter number");
                return num3;
            }

        }

    }
}

