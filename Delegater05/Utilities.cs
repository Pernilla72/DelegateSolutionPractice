using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegater05
{
    public class Utilities
    {
        public static void SortIntArray(int[] intArr)
        {
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < intArr.Length; j++)
                    if (intArr[j] < intArr[minIndex])
                        minIndex = j;
                int tmp = intArr[i];
                intArr[i] = intArr[minIndex];
                intArr[minIndex] = tmp;
            }
        }
    }
}
