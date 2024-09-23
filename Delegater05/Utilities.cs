using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegater05
{
    public class Utilities
    {               //Metoden, SortIntArray, är statisk, så den kan anropas utan att skapa en instans av klassen den tillhör.
        //public static void SortIntArray(int[] intArr) //Metoden SortIntArray tar en parameter, IntArr, och denna
        //                                              //är en array av heltal (int). Det är denna som ska sorteras.
        //{
        //    for (int i = 0; i < intArr.Length - 1; i++)//Forloop; startar vid första elementet i arrayen (i = 0)och går till
        //    {                                           //näst sista (intArr.Lenght -1)
        //        {
        //            int minIndex = i;                   //Håller redapå det minsta indexet, som från start finns på pos i.
        //            for (int j = i + 1; j < intArr.Length; j++) //Den innre for-loopen startar på nästa element = j (j = i + 1)

        //                if (intArr[j] < intArr[minIndex]) //Här kontrollerar vi om det aktuella elementet intArr[j] är mindre
        //                                                  //än det element som finns på index minIndex (som vi tror är det minsta hittills).
        //                                                  //Om sant, uppdaterar vi minIndex så att det pekar på det nya minsta elementet.
        //                    minIndex = j;       // Här updateras minIndex(j) (om det behövdes)
        //            int tmp = intArr[i];
        //            intArr[i] = intArr[minIndex];
        //            intArr[minIndex] = tmp;
        //        }
        //    }
        //}

        //public static int GetMinIndex<T>()
        //{
        //    return minIndex;
        //}

        //public static void SortGenericArray<T>(T[] anyArr, Func<T, T, bool> lessThan) // T istället för int.
        //{
        //    for (int i = 0; i < anyArr.Length - 1; i++)
        //    {
        //        int minIndex = i;
        //        for (int j = i + 1; j < anyArr.Length; j++)

        //            if (lessThan(anyArr[j], anyArr[minIndex]))
        //                minIndex = j;  
        //        T tmp = anyArr[i]; //T istället för int.
        //        anyArr[i] = anyArr[minIndex];
        //        anyArr[minIndex] = tmp;
        //    }
        //}

        public static void SortGenericArray<T>( T[] anyArr, Func<T, T, int> Compare) // För att sortera namn
        {
            for (int i = 0; i < anyArr.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < anyArr.Length; j++)
                {

                    if (Compare(anyArr[j], anyArr[minIndex]) <0)
                    {
                        minIndex = j;
                    }
                    T tmp = anyArr[i]; //T istället för int.
                    anyArr[i] = anyArr[minIndex];
                    anyArr[minIndex] = tmp;
                }
            }
        }
    }
}
