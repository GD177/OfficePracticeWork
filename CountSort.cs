using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Test_App_For_GoAir
{
    class CountSort
    {
        int[] arr = { -5, 0, -3, -5, 5, -1, -1, -1, 4 };
        public void countSort()
        {
            int max = arr.Max();
            int min = arr.Min();
            int range = max - min + 1;

            int[] countArr = new int[range];
            int[] op = new int[arr.Length];
            int[] opDesc = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                countArr[arr[i] - min]++;
            }

            for (int i = 1; i < range; i++)
            {
                countArr[i] += countArr[i - 1];
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                op[countArr[arr[i] - min] - 1] = arr[i];
                countArr[arr[i] - min]--;
            }

            for (int i = 0; i < op.Length; i++)
            {
                Console.WriteLine("Element is " + op[i]);
            }

            Console.WriteLine("Element in decreasing order");

            for (int i = op.Length - 1, j = 0; i >= 0; i--, j++)
            {
                opDesc[j] = op[i];
            }

            for (int i = 0; i < opDesc.Length; i++)
            {
                Console.WriteLine("Element is " + opDesc[i]);
            }
        }
    }
}
