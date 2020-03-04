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
            Dictionary<int, int> countArray1 = new Dictionary<int, int>();
            Dictionary<int, string> dic = new Dictionary<int, string>();

            string testString = "uuudddduddd";
            for (int i = 0; i < testString.Length; i++)
                Console.WriteLine(testString[i]);

            int[] ared = new int[4];

            int[] arr = { 1, 2, 1, 2, 1, 4, 5, 6, 78, 1, 2, 2 };

            for(int i = 0; i < arr.Length; i++)
            {
                if (!countArray.ContainsKey(arr[i]))
                    countArray[arr[i]] = 0;

                countArray[arr[i]] += 1;

                if (!countArray1.ContainsKey(arr[i]))
                    countArray1[arr[i]] = 1;
                else
                    countArray1[arr[i]]++;
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
            char[] b = new char[j + 1];
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

        public static int jumpingOnClouds(int[] c)
        {
            int len = c.Length - 1;
            int j = 0;
            int jumps = 0;
            while (j < len)
            {
                if(j + 2 <= len & c[j+2]==0)
                {
                    jumps++;
                    j += 2;
                }
                else
                {
                    jumps++;
                    j += 1;
                }
            }

            return jumps;
            //return helpeJump(c, 0, 0);
        }

        public static int helpeJump(int[] arr, int currpos, int jumps)
        {
            if (currpos == arr.Length - 1)
                return jumps;


            for (int i = currpos; i < arr.Length;)
            {
                if (arr[i + 2] == 0)
                    helpeJump(arr, i + 2, jumps + 1);
                else
                    helpeJump(arr, i + 1, jumps + 1);
            }
            
            return jumps;
        }

        public static long repeatedString(string s, long n)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            long charCount = 0;
            int strLen = s.Length;

            if (strLen == 1 && s == "a")
                return n;

            //long diff = 0;
            //long sum = 0;
            //long addCount = 0;
            long mulcount = 1;
            long rem = 0;
            //string newString = string.Empty;
            
            if (n > strLen)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'a')
                        charCount++;
                }

                mulcount = n / strLen;

                charCount *= mulcount;

                rem = n % strLen;

                for (int j = 0; j < rem; j++)
                {
                    if (s[j] == 'a')
                        charCount++;
                }

                return charCount;
                //while (sum < n)
                //{
                //    sum += strLen;
                //}

                //sum -= strLen;

                //addCount = sum / strLen;

                //while(addCount!=0)
                //{
                //    newString += s;
                //    addCount--;
                //}

                //diff = n - sum;

                //for (int j = 0; j < diff; j++)
                //    newString += s[j];

                //int ans = s.Count('a');
            }
            
            for(int i = 0; i < n; i++)
            {
                if (s[i] == 'a')
                    charCount++;
            }

            return charCount;
        }

        //Wrong Solution, taking too much steps to sort, although its a kind of sorting
        public static int minimumSwaps(int[] arr)
        {
            int swapCount = 0;
            Stack<int> s = new Stack<int>();
            s.Push(arr[0]);

            int counter = 1;

            while(s.Count != arr.Length && counter < arr.Length)
            {
                if(s.Count == 0)
                {
                    s.Push(arr[0]);
                    counter++;
                }
                
                if (s.Peek() < arr[counter])
                    s.Push(arr[counter++]);
                else
                {
                    int num = s.Pop();
                    int temp = arr[counter];
                    arr[--counter] = temp;
                    arr[counter + 1] = num;
                    swapCount++;
                }
            }

            return swapCount;
        }
    }
}
