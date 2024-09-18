using System.Reflection.Metadata;

namespace Delegater04
{
    internal class Program
    {
        //Skapa en statisk void metod med namnet ”SomeMethod” i klassen Program som tar en string-parameter och en
        //delegatparameter av typen Func<bool>.

        static void SomeMethod(string message, Func<bool> right)
        {

            if (right())
                Console.WriteLine(message.ToUpper());
            else
                Console.WriteLine(message.ToLower());
        }

            static bool UpperCaseOrLowerCase()
            {
            Console.Write("Små eller stora bokstäver? svara JA eller NEJ:");
                string reply = Console.ReadLine();
                bool result = reply.ToUpper() == "JA";
                return result;
            }
        



        static void Main(string[] args)
        {
            //Anropa metoden ”SomeMethod” i ”Main” metoden med ”lämpliga argument”.
            SomeMethod("JAg kan!", UpperCaseOrLowerCase);
        }
    }
}
