using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Test_App_For_GoAir
{
    public class NestedClass
    {
        public static int i;
        public int j;
        private static int k;
        protected int l;

        //Reference to InsideNested Class
        public InsideNested insideNested { get; set; }

        public NestedClass()
        {
            insideNested = new InsideNested();
        }

        public class InsideNested
        {
            public static int insideNestedi;
            public int insideNestedj;
            private int insideNestedk;

            public InsideNested()
            {
                insideNestedj = 2;
                insideNestedi = 1;
                insideNestedk = 3;
                i = 11;
                k = 344;
                //var obj = new NestedClass();
                //obj.l = 90;
            }

            public void method()
            {
                Console.WriteLine("Method of inside nested class");
            }
        }
    }
}
