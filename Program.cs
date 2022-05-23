// See https://aka.ms/new-console-template for more information
using Generic;
class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("\t\t\t\tWelcome to The Generic Concept");

        MaxInteger.ToPrint(40,200,500);
        MaxString.ToPrint1("Tejas", "Rajesh", "Raju");
        Float.ToPrint2(2.2f,3.5f,6.5f);
        Ref1<int> objref1 = new Ref1<int>();
        Ref1<int>.value(90, 100, 80);
        Ref1<String>.value("Tejas", "Raj", "Vaibhav");
        Ref1<Double>.value(5.2f, 9.4, 9.9f);
        Ref2.Print(10, 20, 30);
        Ref2.Print("vaibhav", "Rajesh", "Mohan");
        Ref2.Print(5.6f, 8.8f, 9.4f);

    }
}