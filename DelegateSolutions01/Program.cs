using System;

namespace DelegateExamples01
{
    internal class Program
    {
        //static void MyMethod() 
        //{
        //    Console.WriteLine("Hello World");
        //}

        //static void HittePå()
        //{
        //    Console.Beep(400, 1000);
        //}

        static void Main(string[] args)

        {
            //Tilldela variabeln a av typen Action metoden MyMetod
            //Action metod = MyMethod;

            ////Anropa metoden som variebeln a tilldelats.
            //MyMethod();
            //metod();

            //Action a1 = Action1;
            //Or, use a lambda expression.
            Action a1 = () =>
            {
                Console.Write("Mata in ett namn: ");
                string s = Console.ReadLine();
                Console.WriteLine($"Hej {s}");
            };
            a1();

            Action<string> a2 = (string s) =>

            {
                Console.WriteLine($"Hej {s}!");
            };
            a2("ACADEMY");





        }
    }
}
