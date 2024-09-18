using System.Reflection.Metadata;

namespace Delegater02
{
    internal class Program
    {
        // [Övning 2]
        // Syftet med denna övning är att se hur vi, via delegatvariabler, kan anropa metoder som tar
        //parametrar.  1. Skapa ett Console projekt med namnet Delegater02.
                    // 2. Skapa en statisk void metod i klassen Program med namnet PrintIt som tar en string-parameter
                    // och en bool-parameter.Om bool- parametern är true ska metoden PrintIt skriva ut
                    // string-parametern med stora bokstäver annars med små bokstäver.
                    // 3. Deklarera en generisk Action<> variabel i Main metoden och tilldela variabeln metoden PrintIt.
                    // 4. Använd slutligen den generiska Action<> variabeln för att anropa metoden som den tilldelats
        static void PrintIt(string message, bool UpperCase)
        {
            if (UpperCase)
            {

                Console.WriteLine(message.ToUpper());
            }

            else
            {
                Console.WriteLine(message.ToLower());
            }
        }


        static void Main(string[] args)
        {
            Action<string, bool> printer = PrintIt;  //variabeln printer har tilldelats Actionmetoden PrintIt

            printer("Jag klarade det!", true);

            printer("Jag klarade det", false);

        }
    }
}
