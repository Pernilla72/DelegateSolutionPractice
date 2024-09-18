using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Delegater03
{
    internal class Program
    {
        //Deklarera en statisk metod i klassen Program som returnerar en bool, heter IsLessThan och som tar två stycken int
        //parameter.Om den första int parametern är mindre än den andra int parametern ska metoden returnera true, annars false.

        static bool IsLessThan(int first, int second) 
        {
            if (first < second)
            {
                Console.WriteLine($"Första värdet {first} är mindre än andra värdet {second}");
                return true;
                
            }
            Console.WriteLine($"Första värdet är större än andra värdet");
            return false;
        }

        static void Main(string[] args)
        {
            
            //Deklarera en generisk Func<> variabel i Main metoden och tilldela variabeln metoden IsLessThan.
            // Använd slutligen den generiska Func<> variabeln för att anropa metoden som den tilldelats

            Func<int,int, bool> less = IsLessThan;  //variabeln less har tilldelats metoden  IsLEssThan
            
            less (10, 15);
            
            return;
        }
    }
}
