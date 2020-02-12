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

                string[] strArr = { "https://www.hackerearth.com", "https://www.wikipedia.org", "https://www.google.com",
                                    "https://www.hackerearth.com", "https://www.hackerearth.com" };
                sortTheUrls(strArr, 5);

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

            //Array.Sort(result, Comparelexicographical => { return left.Length.CompareTo(right.Length)});

            int[] array = new int[] { 3, 1, 4, 5, 2 };
            Array.Sort(array, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

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

        public static void transposeOfMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Doing Transpose 
            for (int r = 0; r < row; r++)
            {
                for (int c = r + 1; c < col; c++)
                {
                    int temp = matrix[r, c];
                    matrix[r, c] = matrix[c, r];
                    matrix[c, r] = temp;
                }
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
                    Console.Write(matrix[r, n-1]);
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

                for (int c = n-1; c >=0; c--)
                {
                    Console.Write(matrix[k, c]);
                }
                k++;
                Console.WriteLine();
            }
        }
    }
}
