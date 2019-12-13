using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace My_Test_App_For_GoAir
{
    public class MyStack : CollectionStack
    {
        internal class Stack
        {
            int MAX;// = 1000;
            int top;
            int[] stack;// = new int[MAX];

            bool IsEmpty()
            {
                return (top < 0);
            }
            public Stack(int size)
            {
                top = -1;
                MAX = size;
                stack = new int[MAX];
            }
            internal void Push(int data)
            {
                if (top >= MAX)
                {
                    Console.WriteLine("Stack Overflow");
                    //return false;
                }
                else
                {
                    stack[++top] = data;
                    //return true;
                }
            }

            internal int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return 0;
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            }

            internal void Peek()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                    Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
            }

            internal void PrintStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the Stack are :");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
        }

        public class muttableClsTest
        {
            public static string str1;
            public muttableClsTest(string passtr)
            {
                getString = passtr;
            }

            public string getString { get; }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                #region
                //muttableClsTest obj = new muttableClsTest("hello");
                //Console.WriteLine(obj.getString);
                //Stack myStack = new Stack(5);

                //myStack.Push(10);
                //myStack.Push(20);
                //myStack.Push(30);
                //myStack.Push(40);
                //myStack.PrintStack();
                //myStack.Peek();
                //Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
                //myStack.PrintStack();
                //Console.ReadLine();
                //Console.WriteLine("Read");
                //int key = Console.Read();
                //Console.WriteLine("ReadKey");
                //var key1 = Console.ReadKey();
                //Console.WriteLine("ReadLine");
                //string key2 = Console.ReadLine();
                //ThreadStaticAttribute thread = new ThreadStaticAttribute();

                //CollectionStack collectionStack = new CollectionStack();
                //MyCollectionStack();
                //NextGreaterElement();
                //printpairs(16);
                //removeDuplicatesfromStringUsingStack();
                //collectionStack.firstNonRepeating();
                //StringBuilder resString = collectionStack.RemoveDuplicate();
                //collectionStack.dictionaryExCountArray();
                //Console.WriteLine("String is : " + resString);
                #endregion

                InterfaceTest interfaceTest = new InterfaceTest();
                interfaceTest.method();

                inter2 inter2 = new InterfaceTest();
                inter2.method();

                inter1 inter1 = new InterfaceTest();
                inter1.method();

                //A obj = new A(); //A constructor
                //B objB = new B(); //B constructor
                //B objx = (B)new A(); //cannot do this, cannot assign memory reference of parent class to child class
                //A obja = new B(2); //A constructor and than B constructor

                A a = new C();
                Console.WriteLine("----");
                B b = new C();
                Console.WriteLine("====");
                #region
                A objz = new B();
                objz.method();
                Console.WriteLine("----");
                B obj1 = new B();
                obj1.method();
                Console.WriteLine("----");
                C obj2 = new C();
                obj2.method();
                Console.WriteLine("----");
                A obj3 = new C();
                obj3.method();
                Console.WriteLine("----");
                B obj4 = new C();
                obj4.method();
                Console.WriteLine("----");
                C obj5 = new C();
                obj5.method();
                Console.WriteLine("=====");
                #endregion

                //AbstractTest objabs = new AbstractTest();

                A aa = new B();
                aa.method();
                //B bb = new A();
                //C cc = new B();

                //CountSort countSort = new CountSort();
                //countSort.countSort();

                //Nested Class test
                NestedClass nestedClass = new NestedClass();
                nestedClass.j = 2;
                nestedClass.insideNested.method();

                //NestedClass.InsideNested insideNested = new NestedClass.InsideNested();
                //insideNested.method();

                try
                {
                    LinkedList linkedList = new LinkedList();

                    //int i = 10;
                    //float x = 2.3F;

                    //float j = i / 0;

                    StringBuilder stringbuilder = new StringBuilder();
                    string stringbuil = System.IO.File.ReadAllText(@"E:\test\SaveLCC.txt");
                    stringbuilder.Append(stringbuil);

                    throw new Exception();
                    Console.WriteLine("after exception");
                    //for (int i = 0; i < 5; i++)
                    //    linkedList.push(i);

                    //linkedList.printLL();

                    //linkedList.add(10);
                    //linkedList.printLL();
                    //return;
                }
                catch (Exception ex)
                {
                    //Do nothing
                    Console.WriteLine("Inside Catch block");
                    //return;
                }
                finally
                {
                    Console.WriteLine("Inside Finally block");
                    //Console.ReadKey();
                }
                Console.WriteLine("after Finally block");
                try
                {
                    string test = "456|223|434";
                    var id = test.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    newA oba = new newA();
                    oba.method();
                    newA obb = new newB();
                    obb.method();
                    newA obc = new newC();
                    obc.method();
                    newC obc1 = new newC();
                    obc1.method();

                    //StaticTest s = new StaticTest();
                    Console.WriteLine(StaticTest.i);// + " " + s.j);//only reference also works for variables or memebers

                    //throw new Exception();

                    //int memid = 434;
                    //if (id.Contains(memid.ToString()))
                    //{
                    //    Console.WriteLine("true");
                    //}

                    //printAllSubSequence("abc", "");
                    //printAllSubSequenceWdArrayList();
                    KeypadProblem("123", "");
                    Console.WriteLine("----------------------------------------");
                    ArrayList arrayList = new ArrayList();
                    arrayList = KeypadProblemWdArrayList("123", "", arrayList);
                    foreach (var item in arrayList)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("------------RatMaze----------------------------");
                    RatMazeProblem(0, 0, 2, 2, "");
                    Console.WriteLine("------------RatMazeWithDiagonal----------------------------");
                    //RatMazeProblemWdDiagonal(0, 0, 3, 3, "");
                }
                catch(ArgumentNullException ex)
                {

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Caught");
                }


                int[] arr = new int[] { -5, 0, 2, 3, 10, 29 };//-8, 0, 1, 3, 5 };//-5, 0, 3, 4, 10, 18, 27 };-5,0,2,3,10,29
                int index = IndexEqualsValueSearch(arr);
                //IList<int> list;
                //list.Add(1);
                //List<int> vs = new List<int>();

                //int ans = NumWays("123");
                int z = RomanToInt("MCMXCIV");
                int  x = LengthOfLongestSubstring("au");
                Stack<char> s = new Stack<char>();
                

                Console.ReadKey();
            }
        }

        public static void RatMazeProblemWdDiagonal(int sr, int sc, int dr, int dc, string ans)
        {
            if (sr == dr && sc == dc)
            {
                Console.WriteLine(ans);
                return;
            }

            if (sr > dr || sc > dc)
                return;

            RatMazeProblemWdDiagonal(sr, sc + 1, dr, dc, ans + "H");
            RatMazeProblemWdDiagonal(sr + 1, sc + 1, dr, dc, ans + "D");
            RatMazeProblemWdDiagonal(sr + 1, sc, dr, dc, ans + "V");
        }
        public static void RatMazeProblem(int sr, int sc, int dr, int dc, string ans)
        {
            if (sr == dr && sc == dc)
            {
                Console.WriteLine(ans);
                return;
            }

            //if (sr > dr || sc > dc)
            //    return;
            if (sc <= dc)
                RatMazeProblem(sr, sc + 1, dr, dc, ans + "H");
            if (sr <= dr)
                RatMazeProblem(sr + 1, sc, dr, dc, ans + "V");
        }

        public static string[] code = { ".", "ab", "cd", "ef", "gh", "ij", "kl", "mn", "op", "qr", "st", "uv", "wx", "yz" };
        public static string[] code1 = { ".", "abc", "def", "ghi", "jkl", "mno", "pqr", "stu", "vwx", "yz" };

        public static ArrayList KeypadProblemWdArrayList(string input, string ans, ArrayList arrayList)
        {
            if (input.Length == 0)
            {
                Console.WriteLine(ans);
                return arrayList;
            }

            char ch = input[0]; //1
            string str = input.Substring(1); //23
            string chcode = code[ch - '0']; //ab

            for (int i = 0; i < chcode.Length; i++)
            {
                char chcdr = chcode[i];
                KeypadProblem(str, ans + chcdr);
            }

            return arrayList;
        }

        public static void KeypadProblem(string input, string ans)
        {
            if (input.Length == 0)
            {
                Console.WriteLine(ans);
                return;
            }

            char ch = input[0]; //1
            string str = input.Substring(1); //23
            string chcode = code[ch - '0']; //ab

            for (int i = 0; i < chcode.Length; i++)
            {
                char chcdr = chcode[i];
                KeypadProblem(str, ans + chcdr);
            }
        }

        public static void printAllSubSequenceWdArrayList()
        {
            ArrayList arrList = new ArrayList();

            arrList = printAllSubSequenceWdArrayListFun("abc", "", arrList);

        }

        public static ArrayList printAllSubSequenceWdArrayListFun(string q, string a, ArrayList arrList)
        {
            if (q.Length == 0)
            {
                arrList.Add(a);
                //Console.WriteLine(string.IsNullOrWhiteSpace(a) ? "empty" : a);
                return arrList;
            }

            char ch = q[0];
            string sub = string.Empty;
            //if (q.Length !=1)
            sub = q.Substring(1);

            printAllSubSequenceWdArrayListFun(sub, a, arrList);

            printAllSubSequenceWdArrayListFun(sub, a + ch, arrList);
            return arrList;
        }

        public static void printAllSubSequence(string q, string a)
        {
            if (q.Length == 0)
            {
                Console.WriteLine(string.IsNullOrWhiteSpace(a) ? "empty" : a);
                return;
            }

            char ch = q[0];
            string sub = string.Empty;
            //if (q.Length !=1)
            sub = q.Substring(1);

            printAllSubSequence(sub, a);
            printAllSubSequence(sub, a + ch);
        }

        public void minMaxValue()
        {
            int[] arr = { 1, 2, 4, 1, 9, 3, 7, 8 };
            int n = arr.Length;

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Max : " + max);
            Console.WriteLine("Min : " + min);
            Console.ReadLine();
            //Console.WriteLine("Test Method");
        }

        public static int IndexEqualsValueSearch(int[] arr)
        {
            // your code goes here
            int l = 0;
            int r = arr.Length - 1;
            int m;//= (r - l) / 2;
            while (l <= r)
            {
                m = l + (r - l) / 2;
                if (l == r && arr[l] == l)
                    return l;

                if (arr[m] == m)
                    return m;

                if (arr[m] > m)
                {
                    r = m - 1;
                    //m = (r - l) / 2;
                }
                else
                {
                    l = m + 1;
                    //m = (r - l) / 2;
                }
            }

            return -1;
        }

        public static int NumWays(string data)
        {
            int[] memo = new int[data.Length + 1];
            int res = Helper(data, data.Length, memo, 0);
            return res;
        }

        private static int Helper(string data, int k, int[] memo, int res)
        {
            if (k == 0)
                return 1;

            int s = data.Length - k;
            if (data[s] == '0')
                return 0;

            res = Helper(data, k - 1, memo, res) + res;

            //if (k >= 2 && Convert.ToInt32(data[s] + data[s + 1]) <= 26)
            //    res += Helper(data, k - 2, memo, res);

            return res;
        }

        public static int RomanToInt(string s)
        {
            int ans = 0;
            char prev = '\0';
            char curr = '\0';
            //foreach(char c in s)
            for(int i = 0 ; i < s.Length; i++)
            {
                if(i != 0)
                    prev = s[i-1];
                curr = s[i];
                
                if(s[i] == 'I')
                {
                    ans += 1;
                }
                else if(s[i] == 'V')
                {
                    ans += 5;
                    if(prev == 'I' && prev != '\0')
                    {
                        ans -= 2;
                    }
                }
                else if (s[i] == 'X')
                {
                    ans += 10;
                    if (prev == 'I' && prev != '\0')
                    {
                        ans -= 2;
                    }
                }
                else if (s[i] == 'L')
                {
                    ans += 50;
                }
                else if (s[i] == 'C')
                {
                    ans += 100;
                }
                else if (s[i] == 'D')
                {
                    ans += 500;
                }
                else if (s[i] == 'M')
                {
                    ans += 1000;
                }
                
                //switch (s[i])
                //{
                //    case 'I':
                //        ans += 1;
                //        break;
                //    case 'V':
                //        ans += 5;
                //        if(prev == 'I')
                //        {

                //        }
                //        break;
                //    case 'X':
                //        ans += 10;
                //        break;
                //    case 'L':
                //        ans += 50;
                //        break;
                //    case 'C':
                //        ans += 100;
                //        break;
                //    case 'D':
                //        ans += 500;
                //        break;
                //    case 'M':
                //        ans += 1000;
                //        break;
                //}
            }

            return ans;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrWhiteSpace(s) && s.Length < 1)
                return 0;
            Dictionary<char, int> map = new Dictionary<char, int>();

            int len = s.Length - 1;
            int count = 0;
            int fc = 1;
            for (int i = 0; i < s.Length; i++)
            {
                count++;
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], 0);
                }
                else
                {
                    count = 1;
                    map[s[i]]++;
                }
                
                if (fc < count)
                    fc = count;
            }

            //if (map[s[len]] < 1)
            //    fc++;

            //int n = s.length();
            //unordered_map<char, int> m;
            //int ans = 0;
            //int start = 0, i = 0;
            //while (i < n)
            //{
            //    if (m.find(s[i]) == m.end())
            //        m[s[i]] = i;
            //    else
            //    {
            //        if (m[s[i]] + 1 > start)
            //            start = m[s[i]] + 1;
            //        m[s[i]] = i;
            //    }
            //    ans = max(ans, i - start + 1);
            //    ++i;
            //}
            //return ans;

            return fc;
        }
    }
}
