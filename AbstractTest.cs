using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Test_App_For_GoAir
{
    abstract class AbstractTest
    {
        public AbstractTest()
        {
            Console.WriteLine("Constructor of abstract class");
        }

        public int asb;
        public void method()
        {
            Console.WriteLine("non- abstract method");
        }
        public abstract void method1();
        public abstract void method2();

        public virtual void virtualTest()
        {
            Console.WriteLine("We can provide a new implementation of this in derieved method");
        }
    }

    class AbsInherit : AbstractTest
    {
        void method1(int i)
        {

        }
        public override void method1()
        {

        }
        void method2(int j)
        {

        }
        public override void method2()
        {

        }

        public override void virtualTest()
        {

            //base.virtualTest();
        }
    }
}
