using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Test_App_For_GoAir
{
    class StaticTest
    {
        int num = int.MinValue;
        public static int i;
        public int j;
        static StaticTest()
        {
            i = 10;
            StaticTest obj = new StaticTest();
            obj.j = 20;
        }
    }
}
