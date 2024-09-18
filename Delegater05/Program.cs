using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace Delegater05
{
    public class Program
    {
//        Skapa ett Console projekt med namnet Delegater05.
// Skapa en klass Utilities och kopiera och klistra in metoden i ”Exempel 6:” ovan i klassen.
// Deklarera en int array med fem element med värdena 3, 4, 1, 5 och 2 i programmets Main
//metod.
// Skriv ut värdena i array:en på skärmen.Anropa metoden SortIntArray och skriv slutligen på
//nytt ut värdena i array:en för att säkerställa att de sorterats.

        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 1, 5, 2 };
            Console.WriteLine("Osorterade numer");
            Array.ForEach(numbers, number => Console.WriteLine(number + " "));


            Utilities.SortIntArray(numbers);
            Console.WriteLine("Sorterade nummer: ");
            Array.ForEach(numbers, i => Console.WriteLine(i + " "));
        }
    }
}
