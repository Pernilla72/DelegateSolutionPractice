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
            //int[] numbers = { 3, 4, 1, 5, 2 };
            //Console.WriteLine("Osorterade numer");
            //Array.ForEach(numbers, number => Console.WriteLine(number + " "));

            //Utilities.SortGenericArray(numbers, (a, b) => a > b);
            //Console.WriteLine("Sorterade nummer: ");
            //Array.ForEach(numbers, i => Console.WriteLine(i + " "));

            //[Exempel 9]


            //string[] strArr = new string[]
            //{ "Håkan", "Gudrun", "Karl", "Anna", "David", "Cecilia"};

            //Utilities.SortGenericArray(strArr, (a, b) => string.Compare(a, b, true) < 0);  //kolla upp

            //Console.WriteLine("Sorterade namn:");

            //Array.ForEach(strArr, name => Console.WriteLine(name));



            Contact[] MyContacts = new Contact[]
            {
                new("Berit", "Grund", 55),
                new("Berit", "Grund", 15),
                new("Signhild", "Holmén", 35),
                new("Dorita", "Trulsson", 65),
                new("Evelyn", "Jönsson", 45),
                new("Paulina", "Grund", 45),
                new("Pauline", "Grund", 45),
                new("Paul", "Grund", 45),
                new("Paulinn", "Grundén", 48),
            };

            Utilities.SortGenericArray(MyContacts, CompareContacts);

            //Utilities.SortGenericArray(MyContacts, (a, b) =>
            //{
               
            //    //int result = string.Compare(a.LastName, b.LastName);
            //    //if (result == 0)
            //    //{
            //    //    result = string.Compare(a.FirstName, b.FirstName);
            //    //    if (result == 0)
            //    //    {
            //    //        result = a.Age.CompareTo(b.Age);
            //    //    }
            //    //}
            //    //return result;
            //});

            foreach (var contact in MyContacts)
            {
                Console.WriteLine(contact);
            }
        }

        public static int CompareContacts(Contact a, Contact b)
        {
            int result = string.Compare(a.LastName, b.LastName);
            if (result == 0)
            {
                result = string.Compare(a.FirstName, b.FirstName);
                if (result == 0)
                {
                    result = a.Age.CompareTo(b.Age);
                }
            }
            return result;
        }
    } 
} 



