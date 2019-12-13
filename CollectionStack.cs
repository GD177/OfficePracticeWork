using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Test_App_For_GoAir
{
    public class CollectionStack
    {
        public static void MyCollectionStack()
        {
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < 10; i++)
                s.Push(i);
            int count = s.Count();

            //MyStack myStack = (MyStack)new CollectionStack();//parent clss ka obj in child class obj do explicit typ casting.But will give runtime error.
            //myStack.minMaxValue();

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Dequeue();

        }
        
        public static void NextGreaterElement()
        {
            int[] arr = { 11, 13, 21, 3, 4, 25, 1, 2, 7 };
        }

        public StringBuilder RemoveDuplicate()
        {
            string str = "KKKLKLLLHHMMOOO";
            StringBuilder finalStr = new StringBuilder();
            int i = 0;
            for (i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    i++;
                    continue;
                }
                finalStr.Append(str[i]);
            }
            if((i-1) % 2 == 0)
            {
                //finalStr += str[i - 1];
            }
                
            Console.Write("Str Length is: " + str.Length);

            return finalStr;
        }

        public void dictionaryExCountArray()
        {
            Dictionary<int, int> countArray = new Dictionary<int, int>();

            Dictionary<int, string> dik = new Dictionary<int, string>();

            int[] ared = new int[4];

            int[] arr = { 1, 2, 1, 2, 1, 4, 5, 6, 78, 1, 2, 2 };

            for(int i =0; i < arr.Length; i++)
            {
                if (!countArray.ContainsKey(arr[i]))
                    countArray[arr[i]] = 0;

                countArray[arr[i]]+= 1;
            }

            foreach(KeyValuePair<int, int> freq in countArray)
            {
                Console.WriteLine("Element : " + freq.Key + "| " + "Count is : "+ freq.Value);
            }

            return;
        }

        protected static void printpairs(int sum)
        {
            int[] arr = {1, 4, 45, 6, 10, 8,6,-26};
            //HashSet<int> s = new HashSet<int>(); 
            Dictionary<int, int> hm = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!hm.ContainsKey(arr[i]))
                {
                    hm[arr[i]] = 0;
                }

                hm[arr[i]] = hm[arr[i]] + 1;
            }

            int count = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                int temp = sum - arr[i];

                // checking for condition 
                if (temp >= 0 && hm.ContainsKey(temp))
                {
                    Console.WriteLine("Pair with given sum " +
                                sum + " is (" + arr[i] +
                                    ", " + temp + ")");
                    count++;
                }
                //s.Add(arr[i]); 
            }
            Console.WriteLine("Count : " + count);
        }

        public static void removeDuplicatesfromStringUsingStack()
        {
            string str = "KKLKLLLHHMMOO";
            List<char> list = new List<char>();
            Stack<char> vs = new Stack<char>();
            vs.Push(str[0]);
            char element;
            for(int i =1;i < str.Length; i++)
            {
                if(vs.Count > 0)
                {
                    element = vs.Pop();
                    if(element.Equals(str[i]))
                    {
                        continue;
                    }
                    else
                    {
                        list.Add(element);
                        vs.Push(str[i]);
                    }
                }
                else
                {
                    vs.Push(str[i]);
                }
            }

            while(vs.Count > 0)
            {
                list.Add(vs.Pop());
            }

            foreach(char i in list)
            {
                Console.Write(" "+ i +" ");
            }

            Console.WriteLine(" for loop ");

            for (int i =0; i < list.Count; i++)
            {
                Console.Write(" " + list[i] + " ");
            }

            return;
        }

        public void firstNonRepeating()
        {
            string str = "geeksforgeeks";

            HashSet<char> hash = new HashSet<char>();

            int index = -1;

            Console.WriteLine(str.Length);

            for(int i = str.Length-1; i >=0;i--)
            {
                if (hash.Contains(str[i]))
                {
                    continue;
                }
                else
                {
                    index = i;
                    hash.Add(str[i]);
                }
            }

            if (index == -1)
                Console.WriteLine("No element present");
            else
                Console.WriteLine("The first non Repeating element is : " + str[index]);
        }
        private void random()
        {
            List<int> elements = new List<int>() { 1, 1, 1, 5, 1, 9, 6, 8, 9, 5, 6, 1 };   //result will 1,5,9,6,8
            Console.WriteLine("The list of elements : ");
            foreach (int elem in elements)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            HashSet<int> hashelements = new HashSet<int>(elements);
            Console.WriteLine("after hash the list is : ");
            foreach (int elem in hashelements)
            {
                Console.Write(elem + " ");
            }
            Console.ReadKey();

            //=============================

            string ABC = "aaabbcccee"; //result should be abce
            char[] arr = ABC.ToCharArray();
            Console.WriteLine("The list of elements : ");
            Console.WriteLine(ABC[0]);

            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int j = 0;
            for (int i = 0; i < len - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    arr[j] = arr[i];
                    j++;
                }
            }
            arr[j++] = arr[len - 1];
            char[] b = new Char[j + 1];
            Array.Copy(arr, 0, b, 0, j + 1);
            Console.WriteLine("The required list :");
            for (j = 0; j < b.Length; j++)
            {
                Console.Write(b[j] + " ");
            }
            Console.ReadKey();
        
        //int[] b = new int[3];
        //Array.Copy(a, 1, b, 0, 3);
        }
    }
}
