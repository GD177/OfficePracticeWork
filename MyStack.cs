using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Test_App_For_GoAir
{
    public class MyStack : CollectionStack
    {
        internal class Stack
        {
            private readonly int MAX;// = 1000;
            private int top;
            private readonly int[] stack;// = new int[MAX];

            private bool IsEmpty()
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
                {
                    Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
                }
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
            public static List<string> sortList = new List<string> { "hello", "yes!!", "ok", "hell", "amazing" };

            //sortList.Add("hello");
            //    sortList.Add("yes!! hello");
            //    sortList.Add("ok");
            //    sortList.Add("hell");
            //    sortList.Add("amazing");

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

                CollectionStack collectionStack = new CollectionStack();
                //MyCollectionStack();
                //NextGreaterElement();
                //printpairs(16);
                //removeDuplicatesfromStringUsingStack();
                //collectionStack.firstNonRepeating();
                //StringBuilder resString = collectionStack.RemoveDuplicate();
                collectionStack.dictionaryExCountArray();
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
                NestedClass nestedClass = new NestedClass
                {
                    j = 2
                };
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
                catch (Exception)
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
                    string[] id = test.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

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
                    foreach (object item in arrayList)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("------------RatMaze----------------------------");
                    RatMazeProblem(0, 0, 2, 2, "");
                    Console.WriteLine("------------RatMazeWithDiagonal----------------------------");
                    //RatMazeProblemWdDiagonal(0, 0, 3, 3, "");
                }
                catch (ArgumentNullException)
                {

                }
                catch (Exception)
                {
                    Console.WriteLine("Exception Caught");
                }


                int[] arr = new int[] { -5, 0, 2, 3, 10, 29 };//-8, 0, 1, 3, 5 };//-5, 0, 3, 4, 10, 18, 27 };-5,0,2,3,10,29
                int index = IndexEqualsValueSearch(arr);
                //IList<int> list;
                //list.Add(1);
                //List<int> vs = new List<int>();

                //int ans = NumWays("123");
                //int z = RomanToInt("MCMXCIV");
                //int  x = LengthOfLongestSubstring("au");
                //Stack<char> s = new Stack<char>();
                //1,2,6,3,4,5,6
                ListNode listNode = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                    }
                };
                listNode.next.next.next = new ListNode(4)
                {
                    next = new ListNode(5)
                };
                //listNode.next.next.next.next.next = new ListNode(5);
                //listNode.next.next.next.next.next.next = new ListNode(6);
                ListNode list = RemoveElements(listNode, 1);
                ListNode list1 = OddEvenList(listNode);

                ListNode l1 = new ListNode(2)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(3)
                    }
                };
                ListNode l2 = new ListNode(5)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(4)
                    }
                };
                ListNode sumOfList = AddTwoNumbers(l1, l2);

                //5,1,5,5,5,null,5
                TreeNode root = new TreeNode(5)
                {
                    left = new TreeNode(5),
                    right = new TreeNode(5)
                };
                root.left.left = new TreeNode(5);
                root.left.right = new TreeNode(5);
                //root.right.right = new TreeNode(5);
                root.right.right = new TreeNode(5);

                int ansOfTree = CountUnivalSubtrees(root);

                //string test1 = null;
                //string test1 = "";
                DateTime dt = DateTime.Now;

                //var ans = test1.ToString();
                //var ans1 = Convert.ToString(test1);
                //var dtans = dt as string;//dt.ToString();
                //var dtans1 = Convert.ToString(dt);

                int queenans = nQueens(2);

                IList<IList<int>> listAns = Combine(2, 1);

                int firstbadversion = FirstBadVersion(3);

                int jumpcount = jumpingOnClouds(new[] { 0, 0, 1, 0, 0, 1, 0 });

                //long stringans = repeatedString("aba", 10);
                long stringans = repeatedString("x", 10);

                //int swapAns = minimumSwaps(new[] { 1, 3, 5, 2, 4, 6, 7 });
                int swapAns = minimumSwaps(new[] { 4, 3, 1, 2 });

                //======================================
                //SORT STRING USING CUSTOM SORTING
                //List<string> sortList = new List<string>();
                //sortList.Add("hello");
                //sortList.Add("yes!! hello");
                //sortList.Add("ok");
                //sortList.Add("hell");
                //sortList.Add("amazing");
                //sortList.Sort();

                foreach (string item in sortList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();

                //sortList.Sort(new CompareLength<int> ((left, right) => left.Length.CompareTo(right.Length)));
                sortList.Sort(CompareLength);

                //Array.Sort<int>(arr, new Comparison<int>(
                //  (i1, i2) => i2.CompareTo(i1)));


                foreach (string item in sortList)
                {
                    Console.WriteLine(item);
                }
                //======================================

                string[] strArr = { "https://www.hackerearth.com", "https://www.wikipedia.org", "https://www.google.com",
                                    "https://www.hackerearth.com", "https://www.hackerearth.com", "https://www.geeksforgeeks.org" };
                sortTheUrls(strArr, strArr.Length);

                List<List<int>> A = new
                     List<List<int>> { new List<int> { 1, 2, 3, 4 }, new List<int> { 5, 6, 7, 8 }, new List<int> { 9, 10, 11, 12 } };

                print2DListInterviewBit(A);

                int[][] hourGlass = new int[][]
                {
                    new int[] { 1, 1, 1, 0, 0, 0 },
                    new int[] { 0, 1, 0, 0, 0, 0 },
                    new int[] { 1, 1, 1, 0, 0, 0 },
                    new int[] { 0, 0, 2, 4, 4, 0 },
                    new int[] { 0, 0, 0, 2, 0, 0 },
                    new int[] { 0, 0, 1, 2, 4, 0 }
                };
                int hourGlassAns = hourGlassMethod(hourGlass);

                int[,] transposeMatrix = new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                int[,] transposeMatrix1 = new[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 },
                                                { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 }};
                transposeOfMatrix(transposeMatrix1);

                int[,] spiralMatrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
                printMatrixInSpiralOrder(spiralMatrix);

                printMatrxiinZigZagOrder(spiralMatrix);

                //1. { 1, 4, 20, 3, 10, 5 }, sum = 33
                //2. {1, 4, 0, 0, 3, 10, 5}, sum = 7
                //3. {1, 4}, sum = 0
                //4. {10, 0, 2, -2, -20, 10}, sum = 20
                //5. { 10, 2, -2, -20, 10}, sum = -10
                List<int> subarraywdgivensum = subArrayWdGivenSum(new int[] { 10, 2, -2, -20, 10 }, -10);

                int suarraywddic = subArrayWdGivenSumWdDic(new int[] { 3, 4, 7, 2, -3, 1, 4, 2 }, 7);

                //int[] nextGreaterElement = NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });

                SortDictionayExample();

                List<KeyValuePair<int, int>> listArrangePoints = new List<KeyValuePair<int, int>>();
                KeyValuePair<int, int> p1 = new KeyValuePair<int, int>(2, 5);
                KeyValuePair<int, int> p2 = new KeyValuePair<int, int>(3, 6);
                KeyValuePair<int, int> p3 = new KeyValuePair<int, int>(1, 2);
                KeyValuePair<int, int> p4 = new KeyValuePair<int, int>(3, 5);
                KeyValuePair<int, int> p5 = new KeyValuePair<int, int>(5, 1);
                listArrangePoints.Add(p1);
                listArrangePoints.Add(p2);
                listArrangePoints.Add(p3);
                listArrangePoints.Add(p4);
                listArrangePoints.Add(p5);

                ArrangePoints(listArrangePoints);

                List<int> plusOneans = plusOne(new List<int> { 0, 0, 4, 4, 6, 0, 9, 6, 5, 1 });

                //Test strings -> hello , ll
                //helo , ll
                //mississippi , issip
                int StrStrAns = ImplementStrStr("mississippi", "issip");

                SortArrayof012(new int[] { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 });

                ListNode nodeA = new ListNode(4)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(8)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(5)
                            }
                        }
                    }
                };

                ListNode nodeB = new ListNode(5)
                {
                    next = new ListNode(0)
                    {
                        next = new ListNode(1)
                        {
                            next = new ListNode(8)
                            {
                                next = new ListNode(4)
                                {
                                    next = new ListNode(5)
                                }
                            }
                        }
                    }
                };
                ListNode nodeans = GetIntersectionNode(nodeA, nodeB);

                //WallAndGate LeetCode problem
                WallAndGate();

                string max = "7599";
                string strToDo = "7599";
                char[] strToDoArr = strToDo.ToCharArray();
                char[] maxArr = max.ToCharArray();

                FindMaxNumberAfterSwap(strToDoArr, 2, maxArr);

                IsPalindrome("ebeda");

                int numberofappends = NumberOfAppends("abede", out string ans);

                GetPalindrome("mdaam");

                int[] nextGreaterElement = NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });
                var res = NextGreaterElements2(new int[] { 1, 2, 1 });

                Console.WriteLine();
                var permuteAns = Permutations(new int[] { 1, 2, 3 });

                TreeNode n = new TreeNode(0);
                n.left = new TreeNode(-10);
                n.right = new TreeNode(10);

                TreeNode n1 = new TreeNode(5);
                n1.left = new TreeNode(1);
                n1.left.left = new TreeNode(0);
                n1.left.right = new TreeNode(0);
                n1.right = new TreeNode(7);
                var twosumbstans = TwoSumBSTs(n,n1, 17);

                ConvertOpposite(new StringBuilder("geeksForgEeks"));

                Console.WriteLine();

                //MyGeneric<int> obj = new MyGeneric<int>(2);
                MyGeneric obj = new MyGeneric();
                //Console.WriteLine(obj.GetValue());
                //MyGeneric.ComputeMet1();
                Console.WriteLine(obj.ComputeMet(1, 2));
                Console.WriteLine(obj.ComputeMet("1", "2"));

                Console.ReadKey();
            }

            private static int CompareLength(string left, string right)
            {
                string leftString = left;
                string rightString = right;
                Console.WriteLine($"Counter {counter++} , {left} , {right}");
                printList(sortList);
                return left.Length.CompareTo(right.Length);
            }

            public static void printList(List<string> sortList)
            {
                foreach (string i in sortList)
                {
                    Console.Write($" {i}");

                }
                Console.WriteLine();
            }
        }

        private static void SortDictionayExample()
        {
            BoxEqualityComparer boxEqC = new BoxEqualityComparer();

            Dictionary<Box, string> boxes = new Dictionary<Box, string>(boxEqC);

            Box redBox = new Box(4, 3, 4);
            SortedDictionaryExample.AddBox(boxes, redBox, "red");

            Box blueBox = new Box(4, 3, 4);
            SortedDictionaryExample.AddBox(boxes, blueBox, "blue");

            Box greenBox = new Box(3, 4, 3);
            SortedDictionaryExample.AddBox(boxes, greenBox, "green");
            Console.WriteLine();

            Console.WriteLine("The dictionary contains {0} Box objects.",
                              boxes.Count);
        }

        public static void RatMazeProblemWdDiagonal(int sr, int sc, int dr, int dc, string ans)
        {
            if (sr == dr && sc == dc)
            {
                Console.WriteLine(ans);
                return;
            }

            if (sr > dr || sc > dc)
            {
                return;
            }

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
            {
                RatMazeProblem(sr, sc + 1, dr, dc, ans + "H");
            }

            if (sr <= dr)
            {
                RatMazeProblem(sr + 1, sc, dr, dc, ans + "V");
            }
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
                {
                    return l;
                }

                if (arr[m] == m)
                {
                    return m;
                }

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
            {
                return 1;
            }

            int s = data.Length - k;
            if (data[s] == '0')
            {
                return 0;
            }

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
            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0)
                {
                    prev = s[i - 1];
                }

                curr = s[i];

                if (s[i] == 'I')
                {
                    ans += 1;
                }
                else if (s[i] == 'V')
                {
                    ans += 5;
                    if (prev == 'I' && prev != '\0')
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
            {
                return 0;
            }

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
                {
                    fc = count;
                }
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

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }

            //ListNode dummy = new ListNode(0);
            //dummy.next = head;

            ListNode prev = null;
            ListNode curr = head;
            //ListNode nxt = dummy;
            while (curr != null)
            {
                if (curr.val == val && prev == null)
                {
                    curr = head.next;
                    head = head.next;
                }
                else
                {
                    if (curr.val == val)
                    {
                        prev.next = curr.next;
                        curr = curr.next;
                    }
                    else
                    {
                        prev = curr;
                        curr = curr.next;
                    }
                }
            }

            return head;
        }

        public static ListNode OddEvenList(ListNode head)
        {
            #region
            //if (head == null)
            //    return null;

            //ListNode curr = head;
            //ListNode nxt = head;
            //ListNode prev = null;

            //if (curr.next == null || curr.next.next == null)
            //    return head;

            //int i = 1, len = 0;

            //while (curr != null)
            //{
            //    len++;
            //    curr = curr.next;
            //}

            //curr = head;

            //while (curr != null)
            //{
            //    if ((i % 2) == 1 && i < len)
            //    {
            //        if (prev == null)
            //        {
            //            prev = curr;
            //            curr = curr.next;
            //            nxt = curr.next;
            //        }

            //        prev.next = nxt;
            //        curr.next = nxt.next;
            //        nxt.next = curr;
            //        prev = prev.next;
            //        nxt = curr.next;
            //    }
            //    i++;
            //    if (i >= len)
            //        break;
            //}

            //return head;
            #endregion
            if (head == null)
            {
                return null;
            }

            // Initialize first nodes of even and  
            // odd lists  
            ListNode odd = head;
            ListNode even = head.next;

            // Remember the first node of even list so  
            // that we can connect the even list at the  
            // end of odd list.  
            ListNode evenFirst = even;

            while (1 == 1)
            {
                // If there are no more nodes,  
                // then connect first node of even  
                // list to the last node of odd list  
                if (odd == null || even == null ||
                                (even.next) == null)
                {
                    odd.next = evenFirst;
                    break;
                }

                // Connecting odd nodes  
                odd.next = even.next;
                odd = even.next;

                // If there are NO more even nodes  
                // after current odd.  
                if (odd.next == null)
                {
                    even.next = null;
                    odd.next = evenFirst;
                    break;
                }

                // Connecting even nodes  
                even.next = odd.next;
                even = odd.next;
            }
            return head;
        }

        public static ListNode newNode(int val)
        {
            ListNode temp = new ListNode(val)
            {
                next = null
            };

            return temp;
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ans = null;
            ListNode res = null;
            int c = 0;
            int sum = 0;
            while (l1 != null || l2 != null)
            {
                sum = c + (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0);

                c = sum >= 10 ? 1 : 0;
                sum = sum % 10;

                if (ans == null)
                {
                    ans = newNode(sum);
                    res = ans;
                }
                else
                {
                    ans.next = newNode(sum);
                    ans = ans.next;
                }

                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            if (c > 0)
            {
                ans.next = newNode(c);
            }

            return res;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        //Does not work well
        public static int CountUnivalSubtrees(TreeNode root)
        {
            if (root == null)
            {
                return 1;
            }

            int x = CountUnivalSubtreeshelper(root, root.val);
            return x;
        }

        private static int count = 0;
        public static int CountUnivalSubtreeshelper(TreeNode root, int x)
        {
            if (root == null)
            {
                return 0;
            }

            int left = CountUnivalSubtreeshelper(root.left, root.val);
            int right = CountUnivalSubtreeshelper(root.right, root.val);

            if (left == 0 && right == 0)
            {
                count++;
            }
            else
            {
                if ((root.left != null && root.val == root.left.val &&
                   root.right != null && root.val == root.right.val) ||
                   (root.left == null && root.right != null && root.val == root.right.val)
                    || (root.left != null && root.right == null && root.val == root.left.val))
                {
                    count++;
                }

                //if ((root.left != null && root.val == root.left.val) &&
                //   (root.right != null && root.val == root.right.val))
                //    count++;
                //else if (root.left == null && root.right != null && root.val == root.right.val)
                //    count++;
                //else if (root.left != null && root.right == null && root.val == root.left.val)
                //    count++;
            }

            return count;
        }

        public static int queenCounter = 0;
        public static int nQueens(int n)
        {
            bool[,] chess = new bool[n, n];
            queenHelper(chess, 0, -1);
            return queenCounter;
        }

        public static void queenHelper(bool[,] chess, int qpsf, int lqpb)
        {
            if (qpsf == chess.GetLength(0))
            {
                queenCounter++;
                return;
            }

            for (int b = lqpb + 1; b < chess.Length; b++)
            {
                int row = b / chess.GetLength(0);
                int col = b % chess.GetLength(0);
                if (chess[row, col] == false)
                {
                    if (isQueenSafe(chess, row, col))
                    {
                        chess[row, col] = true;
                        queenHelper(chess, qpsf + 1, b);
                        chess[row, col] = false;
                    }
                }
            }

        }

        public static bool isQueenSafe(bool[,] chess, int row, int col)
        {
            int[,] dir =
            {
                {0,-1},//N
                {1,-1},//NE
                {1,0},//E
                {1,1},//SE
                {0,1},//S
                {-1,1},//SW
                {-1,0},//W
                {-1,-1}//NW
            };

            for (int di = 0; di < dir.GetLength(0); di++)
            {
                for (int dist = 1; true; dist++)
                {
                    int ecol = col + dist * dir[di, 0];
                    int erow = row + dist * dir[di, 1];

                    if (ecol < 0 || erow < 0 || ecol >= chess.GetLength(1) || erow >= chess.GetLength(0))
                    {
                        break;
                    }

                    if (chess[erow, ecol] == true)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static IList<IList<int>> final = null;
        public static IList<IList<int>> Combine(int n, int k)
        {
            final = new List<IList<int>>();
            List<int> sub = new List<int>();
            CombineHelper(n, k, 0, 0, 0, sub, "");
            return final;
        }

        public static void CombineHelper(int n, int k, int preVal, int preIdx, int psf, List<int> sub, string ansString)
        {
            if (psf == k)
            {
                string[] temp = ansString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                sub = new List<int>();
                foreach (string item in temp)
                {
                    sub.Add(Convert.ToInt32(item));
                    //sub.Add(Convert.ToInt32(temp[1]));
                }
                final.Add(sub);

                Console.WriteLine(ansString);
                return;
            }

            for (int val = preIdx + 1; val <= n; val++)
            {
                if (val != preVal)
                {
                    //sub.Add(val);
                    CombineHelper(n, k, val, val, psf + 1, sub, ansString + "," + val.ToString());
                    //sub.RemoveAt(preIdx);
                }
            }
        }

        public static int FirstBadVersion(int n)
        {

            /*int l = 1;
            int r = n;

            while(l <=r)
            {
                int m = l + (r - l)/2;

                if(IsBadVersion(m) && l < m && !IsBadVersion(m-1))
                    return m;

                else if(IsBadVersion(m))
                    l = m+1;
                else
                    r = m;
            }

            return -1;*/
            return helper(1, n);
        }

        public static int helper(int l, int r)
        {
            if (l > r)
            {
                return -1;
            }

            if (l == r)
            {
                return l;
            }

            int m = l + (r - l) / 2;

            if (IsBadVersion(m))
            {
                int left = helper(l, m);

            }

            return helper(m + 1, r);
        }

        public static bool IsBadVersion(int n)
        {
            if (n == 1 || n == 2 || n == 3)
            {
                return true;
            }

            return false;
        }

        //Custom Comparator
        //public delegate int Comparison<in T>(T left, T right);
        //public Comparison<T> comparator;

        public static int counter = 0;
        private static int CompareLength(string left, string right)
        {
            string leftString = left;
            string rightString = right;
            Console.WriteLine($"Counter {counter++} , {left} , {right}");

            return left.Length.CompareTo(right.Length);
        }

        private static int CompareLength1(string left, string right)
        {
            return left.Length.CompareTo(right.Length);
        }

        public static string[] sortTheUrls(string[] S, int N)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (string str in S)
            {
                if (!map.ContainsKey(str))
                {
                    map[str] = 1;
                }
                else
                {
                    map[str]++;
                }
            }

            string[] result = new string[map.Count];
            int index = 0;
            foreach (KeyValuePair<string, int> url in map)
            {
                result[index++] = url.Key;
            }

            List<KeyValuePair<string, int>> myList = new List<KeyValuePair<string, int>>();

            foreach (KeyValuePair<string, int> pair in map)
            {
                myList.Add(new KeyValuePair<string, int>(pair.Key, pair.Value));
            }

            myList.Sort(
                delegate (KeyValuePair<string, int> pair1,
                KeyValuePair<string, int> pair2)
                {
                    if (pair1.Value == pair2.Value)
                    {
                        return pair1.Key.CompareTo(pair2.Key);
                    }

                    return pair2.Value - pair1.Value;// this will do decreasing order
                    //return pair1.Value - pair2.Value;// this will do increasing order
                }
            );

            //Array.Sort(result, Comparelexicographical > { return left.Length.CompareTo(right.Length)});

            //int[] array = new int[] { 3, 1, 4, 5, 2 };
            //Array.Sort(array, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            //var sortedMap = map(new SortDictionary());
            //Array.Sort(result, new SortDictionary());

            //Arrays.sort(result, (a, b)-> {
            //    if (map.get(a) == map.get(b))
            //    {
            //        return a.compareTo(b);
            //    }
            //    return map.get(b) - map.get(a);
            //});

            return result;
        }

        private static int Comparelexicographical(string left, string right)
        {
            string leftString = left;
            string rightString = right;
            return left.Length.CompareTo(right.Length);
        }

        public static void print2DListInterviewBit(List<List<int>> A)
        {
            List<List<int>> B = new List<List<int>>();
            for (int i = 0; i < A.Count; i++)
            {
                B.Add(new List<int>());
                //var subList = A[i];
                for (int j = 0; j < A[i].Count; j++)
                {
                    B[i].Add(0);
                }

                for (int j = 0; j < A[i].Count; j++)
                {
                    List<int> sublistB = B[i];
                    List<int> sublistA = A[i];
                    //int[] arr = sublist.ToArray();
                    sublistB[A[i].Count - 1 - j] = sublistA[j];
                }
            }

        }

        public static int hourGlassMethod(int[][] mat)
        {
            if (mat.Length < 3)
            {
                return 0;
            }

            int maxSum = int.MinValue;
            int sum = 0;

            int dr = mat.Length;
            int dc = mat[0].Length;

            for (int r = dc - 3; r >= 0; r--)
            {
                for (int c = dc - 3; c >= 0; c--)
                {
                    sum = mat[r][c] + mat[r][c + 1] + mat[r][c + 2] + mat[r + 2][c] + mat[r + 1][c + 1]
                        + mat[r + 2][c + 1] + mat[r + 2][c + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            return maxSum;
        }

        //transpose Of Matrix
        public static void transposeOfMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            Console.WriteLine("Original Array");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");

            //Doing 1st Transpose 
            for (int r = 0; r < row; r++)
            {
                for (int c = r + 1; c < col; c++)
                {
                    int temp = matrix[r, c];
                    matrix[r, c] = matrix[c, r];
                    matrix[c, r] = temp;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("After 1st Transpose");

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("End 1st Transpose");

            //Doing 2nd Transpose
            //for (int rowNo = 0; rowNo < row; rowNo++)
            //{
            //    int r = rowNo, c = rowNo;
            //    while(r < row - 1 && c < col - 1)
            //    {
            //        int temp = matrix[r, c + 1];
            //        matrix[r, c + 1] = matrix[r + 1, c];
            //        matrix[r + 1, c] = temp;
            //        r++;c++;
            //    }
            //}

            //Console.WriteLine("");
            //Console.WriteLine("After 2nd Transpose");

            //for (int r = 0; r < row; r++)
            //{
            //    for (int c = 0; c < col; c++)
            //    {
            //        Console.Write($"{matrix[r, c]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("End 2nd Transpose");
            Console.WriteLine("");

            //Rotating matrix 90 ^
            for (int r = 0; r < row; r++)
            {
                //start and end are column iterator
                int start = 0;
                int end = col - 1;
                while (start < end)
                {
                    int temp = matrix[r, end];
                    matrix[r, end] = matrix[r, start];
                    matrix[r, start] = temp;
                    end--;
                    start++;
                }
                //OR we can do in this manner also
                /*for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < row / 2; j++)
                    {
                        int temp = matrix[i, row - 1 - j];
                        matrix[i, row - 1 - j] = matrix[i, j];
                        matrix[i, j] = temp;
                    }
                }*/
            }

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //print Matrix In Spiral Order
        public static void printMatrixInSpiralOrder(int[,] matrix)
        {
            int k = 0; //row start 
            int l = 0; //col start
            int m = matrix.GetLength(0); //row end
            int n = matrix.GetLength(1); // col end

            while (k < m && l < n)
            {
                for (int c = l; c < n; c++)
                {
                    Console.Write(matrix[k, c]);
                }
                k++;
                Console.WriteLine();

                for (int r = k; r < m; r++)
                {
                    Console.Write(matrix[r, n - 1]);
                }
                n--;
                Console.WriteLine();

                if (k < m)
                {
                    for (int c = n - 1; c >= l; c--)
                    {
                        Console.Write(matrix[m - 1, c]);
                    }
                    m--;
                }
                Console.WriteLine();

                if (l < n)
                {
                    for (int r = m - 1; r >= k; r--)
                    {
                        Console.Write(matrix[r, l]);
                    }
                    l++;
                }
                Console.WriteLine();
            }
        }

        //print Matrix in ZigZag Order
        public static void printMatrxiinZigZagOrder(int[,] matrix)
        {
            int k = 0; //row start 
            int l = 0; //col start
            int m = matrix.GetLength(0); //row end
            int n = matrix.GetLength(1); // col end

            while (k < m)
            {
                for (int c = l; c < n; c++)
                {
                    Console.Write(matrix[k, c]);
                }
                k++;
                Console.WriteLine();

                for (int c = n - 1; c >= 0; c--)
                {
                    Console.Write(matrix[k, c]);
                }
                k++;
                Console.WriteLine();
            }
        }

        //Do not handle negative number
        public static List<int> subArrayWdGivenSum(int[] arr, int sum)
        {
            List<int> vs = new List<int>();

            int currSum = 0;// arr[0];
            int i = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                currSum += arr[j];

                while (currSum > sum && i < j)
                {
                    currSum -= arr[i];
                    i++;
                }

                if (currSum == sum)
                {
                    vs.Add(i);
                    vs.Add(j);
                }
            }
            //vs.ToArray();
            return vs;
        }

        //Handle's negative number
        public static int subArrayWdGivenSumWdDic(int[] arr, int sum)
        {
            int count = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            int currSum = 0;
            map.Add(0, 1);

            for (int i = 0; i < arr.Length; i++)
            {
                currSum += arr[i];

                //if (currSum == sum)
                //    count++;

                if (map.ContainsKey(currSum - sum))
                {
                    count += map[currSum - sum];
                }

                if (map.ContainsKey(currSum))
                {
                    map[currSum] += 1;
                }
                else
                {
                    map[currSum] = 1;
                }
            }

            return count;
        }

        //NextGreaterElement -> Not complete
        public static int[] NextGreaterElementOld(int[] nums1, int[] nums2)
        {
            List<int> ans = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                int j = i;
                while (j < nums2.Length && nums1[i] >= nums2[j])
                {
                    j++;
                }

                if (j == nums2.Length)
                {
                    ans.Add(-1);
                }
                else
                {
                    ans.Add(nums2[j]);
                }
            }

            return ans.ToArray();
        }

        //Arrange points Hacker Earth
        public static List<KeyValuePair<int, int>> ArrangePoints(List<KeyValuePair<int, int>> list)
        {
            List<KeyValuePair<int, int>> finalans = new List<KeyValuePair<int, int>>();

            list.Sort(delegate (KeyValuePair<int, int> pair1, KeyValuePair<int, int> pair2)
            {
                if (pair1.Key == pair2.Key)
                {
                    return pair2.Value - pair1.Value;
                }

                return pair1.Key - pair2.Key;
            });

            foreach (KeyValuePair<int, int> item in list)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            return list;
            //int n = Convert.ToInt32(Console.ReadLine());
            //var list1 = new List<KeyValuePair<int, int>>();
            //for (int i = 0; i < n; i++)
            //{
            //    var a = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            //    var newPair = new KeyValuePair<int, int>
            //    (Convert.ToInt32(Console.ReadLine()),
            //     Convert.ToInt32(Console.ReadLine()));
            //    //int a = Console.Read();
            //    //int b = Console.Read();
            //    //newPair.Add(a,b);
            //    list1.Add(newPair);
            //}

            //list1.Sort(delegate (KeyValuePair<int, int> p1, KeyValuePair<int, int> p2)
            //{
            //    if (p1.Key == p2.Key)
            //        return p2.Value - p1.Value;

            //    return p1.Key - p2.Key;
            //});

            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //return list1;
        }

        //Plus One
        public static List<int> plusOne(List<int> A)
        {
            int carry = 0;
            int sum = 0;
            List<int> arr = new List<int>();
            for (int i = A.Count - 1; i >= 0; i--)
            {
                if (i == A.Count - 1)
                {
                    sum = A[i] + 1;
                }

                if (sum < 10)
                {
                    if (sum != 0)
                    {
                        arr.Add(sum);
                        sum = 0;
                    }
                    else
                    {
                        if (carry == 1)
                        {
                            sum = A[i] + carry;
                        }

                        if (sum == 10)
                        {
                            arr.Add(0);
                        }
                        else
                        {
                            arr.Add(A[i] + carry);
                            carry = 0;
                        }
                        sum = 0;
                    }
                }
                else
                {
                    if (sum != 0)
                    {
                        arr.Add(0);
                        carry = 1;
                        sum = 0;
                    }

                }
            }

            if (carry == 1)
            {
                arr.Add(arr[0] + 1);
            }

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    arr.RemoveAt(i);
                }
                else
                {
                    break;
                }
            }
            arr.Reverse();

            return arr;
        }

        //Implement StrStr -> Not completed
        public static int ImplementStrStr(string haystack, string needle)
        {
            int index = -1;
            int i = 0;
            int j = 0;
            int hLen = haystack.Length;
            int nLen = needle.Length;
            bool flag = false;

            while (i < hLen && j < nLen)
            {
                if (haystack[i] != needle[j])
                {
                    i++;
                    continue;
                }

                if (!flag)
                {
                    index = i;
                    flag = true;
                }
                i++;
                j++;
            }

            if (j != nLen)
            {
                index = -1;
            }

            return index;
        }

        //Sort an array of 0's, 1's, 2's (Dutch national flag problem)
        public static void SortArrayof012(int[] arr)
        {
            int low = 0;
            int mid = 0;
            int high = arr.Length - 1;

            while (mid <= high)
            {
                switch (arr[mid])
                {
                    case 0:
                        //SwapNumber(ref arr[low++], ref arr[mid++]);
                        SwapClass.Swap(ref arr[low++], ref arr[mid++]);
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        //SwapNumber(ref arr[mid], ref arr[high--]);
                        SwapClass.Swap(ref arr[mid], ref arr[high--]);
                        break;
                }
            }
        }

        private static void SwapNumber(ref int a, ref int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }

        //Get Intersection Node in linked list
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode curr1 = headA, curr2 = headB;

            while (curr1 != curr2)
            {

                if (curr1 == null)
                {
                    curr1 = headB;
                }
                else
                {
                    curr1 = curr1.next;
                }

                if (curr2 == null)
                {
                    curr2 = headA;
                }
                else
                {
                    curr2 = curr2.next;
                }
            }

            return curr1;
        }

        //Wall And Gate
        public static void WallAndGate()
        {
            int[][] rooms = { new int[] {int.MaxValue, -1, 0, int.MaxValue },
                              new int[] {int.MaxValue, int.MaxValue, int.MaxValue, -1 },
                              new int[] {int.MaxValue, -1,int.MaxValue, -1 },
                              new int[] {0, -1, int.MaxValue, int.MaxValue }
                            };
            for(int i = 0; i < rooms.Length; i++)
            {
                for(int j = 0; j < rooms[0].Length; j++)
                {
                    if (rooms[i][j] == 0)
                        dfsForWallsAndGates(i, j, rooms, 0);
                }
            }
        }

        private static void dfsForWallsAndGates(int row, int col, int[][] rooms, int dist)
        {
            if (row < 0 || row >= rooms.Length || col < 0 || col >= rooms[0].Length || dist > rooms[row][col] || rooms[row][col] == -1)
                return;

            rooms[row][col] = dist;
            dfsForWallsAndGates(row + 1, col, rooms, dist + 1);
            dfsForWallsAndGates(row - 1, col, rooms, dist + 1);
            dfsForWallsAndGates(row, col + 1, rooms, dist + 1);
            dfsForWallsAndGates(row, col - 1, rooms, dist + 1);
        }

        //Find max number possible by doing at-most k swaps -> not completed (Airtel HackerEarth)
        public static void FindMaxNumberAfterSwap(char[] str, int k, char[] max)
        {
            if (k == 0)
                return;

            int n = str.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (str[i] < str[j])
                    {
                        //var a = str[i];
                        //var b = str[j];
                        SwapClass.Swap(ref str[i], ref str[j]);

                        var newStr = new string(str);
                        var newMax = new string(max);

                        if (newStr.CompareTo(newMax) > 0)
                            max = str;

                        FindMaxNumberAfterSwap(str, k - 1, max);

                        SwapClass.Swap(ref str[j], ref str[i]);
                    }
                }
            }

        }

        //Check String is palindrome or not
        public static bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            int len = str.Length - 1;

            if (j == 1)
                return true;
                //Console.WriteLine("Yes string is Palindrome");

            while (i < j)
            {
                if (str[i] != str[j])
                {
                    //Console.WriteLine("No string is not Palindrome");
                    return false;
                }
                i++;
                j--;
            }

            return true;
            //char ptr1 = str[0];
            //char ptr2 = str[len - 1];

            //while (ptr2 > ptr1)
            //{
            //    if (ptr1 != ptr2)
            //    {
            //        Console.WriteLine("No string is not Palindrome");
            //        return;
            //    }
            //    ptr1++;
            //    ptr2--;
            //}

            //Console.WriteLine("Yes string is Palindrome");
        }

        //Minimum number of appends required to make string palindrome and the length of string after making it palindromic
        public static int NumberOfAppends(string str, out string ans)
        {
            if (IsPalindrome(str))
            {
                ans = str;
                return 0;
            }

            char c = str[0];
            str = str.Substring(1);

            int val = 1 + NumberOfAppends(str, out ans);
            ans = c + ans + c;
            return val;
            //return 1 + NumberOfAppends(str, out ans);
        }

        //Rearrange characters to form palindrome if possible
        public static void GetPalindrome(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            for(int i = 0; i < str.Length; i++)
            {
                if (map.ContainsKey(str[i]))
                    map[str[i]]++;
                else
                    map[str[i]] = 1;
            }
            
            char firstOddChar = '\0';
            int oddCount = 0;
            
            foreach(var item in map)
            {
                if ((item.Value & 1) == 1)
                {
                    oddCount++;
                    firstOddChar = item.Key;
                }

            }

            if(oddCount > 1 || (oddCount == 1 && str.Length % 2 == 0))
            {
                Console.WriteLine("String cannot be made palindromic");
                return;
            }

            string firstHalf = "";
            string secondHalf = "";

            //foreach (var item in map)
            //{
            //    string s = "";
            //    s.PadLeft(s.Length + (item.Value / 2), item.Key);

            //    firstHalf = s + firstHalf;
            //    secondHalf = secondHalf + s;
            //}

            for (int i = 0; i < map.Count; i++)
            {
                string s = "";
                var newS = s.PadLeft(map.Values.ElementAt(i) / 2, map.Keys.ElementAt(i));
                firstHalf = newS + firstHalf;
                secondHalf = secondHalf + newS;
            }

            string final = "";
            if (oddCount == 1)
                final = firstHalf + firstOddChar.ToString() + secondHalf;
            else
                final = firstHalf + secondHalf;

            return;
        }

        //NextGreaterElement
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            //HashSet<int> set = new HashSet<int>(nums1);
            List<int> ans = new List<int>();

            List<int> numList = new List<int>(nums1);

            int[] res = new int[nums1.Length];
            int j = nums1.Length - 1;

            Stack<int> s = new Stack<int>();

            for(int i = nums2.Length - 1; i >= 0; i--)
            {
                if (numList.Contains(nums2[i]))
                {
                    while (s.Count != 0 && nums2[i] >= s.Peek())
                        s.Pop();

                    res[numList.IndexOf(nums2[i])] = s.Count == 0 ? -1 : s.Peek();
                    s.Push(nums2[i]);
                }
                else
                    s.Push(nums2[i]);
            }

            s.Clear();

            return res;
        }

        //NextGreaterElements2 -> Not Working
        public static int[] NextGreaterElements2(int[] nums)
        {
            int[] res = new int[nums.Length];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; ; j++)
                {
                    j %= nums.Length;
                    if (nums[i] <= nums[j] && j != i)
                    {
                        res[i] = nums[j];
                        break;
                    }
                    if (j == i)
                    {
                        res[i] = -1;
                        break;
                    }
                }
            }

            return res;
        }

        //Permutation of array
        public static IList<IList<int>> Permutations(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            bool[] qb = new bool[nums.Length];
            var subList = new List<int>();
            PermuteHelper(nums, 0, res, qb, "", subList);
            return res;
        }

        public static  void PermuteHelper(int[] nums, int currIndex, IList<IList<int>> res, bool[] qb, string ans, List<int> subList)
        {
            if (subList.Count == nums.Length)
            {
                var n = new List<int>(subList);
                res.Add(n);
                Console.WriteLine(ans);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if(qb[i] == false)
                {
                    qb[i] = true;
                    subList.Add(nums[i]);
                    PermuteHelper(nums, i + 1, res, qb, ans + nums[i], subList);
                    subList.Remove(nums[i]);
                    qb[i] = false;
                }
            }
        }

        public string RemoveDuplicates(string S)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < S.Length; i++)
            {
                if (map.ContainsKey(S[i]))
                    map[S[i]]++;
                else
                    map[S[i]] = 1;
            }

            string ans = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (map.ContainsKey(S[i]) && map[S[i]] == 2)
                    map.Remove(S[i]);
            }

            foreach (var item in map)
            {
                ans += item.Key;
            }

            List<int> ll = new List<int>();
            ll.Sort();
            ll.RemoveAt(0);
            return ans;
        }

        //Find pair from two trees with given target
        public static bool TwoSumBSTs(TreeNode root1, TreeNode root2, int target)
        {
            HashSet<int> map = new HashSet<int>();
            helperInorder(root1, map);

            return sumHelper(root2, map, target);
        }

        public static bool sumHelper(TreeNode root, HashSet<int> map, int target)
        {
            if (root == null)
                return false;

            if (map.Contains(target - root.val))
                return true;

            return sumHelper(root.left, map, target) || sumHelper(root.right, map, target);
        }

        public static void helperInorder(TreeNode root, HashSet<int> map)
        {
            if (root == null)
                return;

            //HashSet<int> set = new HashSet<int>();
            //set.Remove(1);

            map.Add(root.val);
            helperInorder(root.left, map);
            helperInorder(root.right, map);
        }

        //Convert characters of a string to opposite case i.e if it is lower case change to upper case and vice versa
        public static void ConvertOpposite(StringBuilder str)
        {
            Console.WriteLine($"Before Changing - {str}");

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] >= 'a' && str[i] <= 'z')
                {
                    str[i] = (char)(str[i] - 32);
                }
                else
                {
                    str[i] = (char)(str[i] + 32);
                }
            }

            Console.WriteLine($"After Changing - {str}");

            string number = "1234";

            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i] - '0');
            }

        }
    }
}
