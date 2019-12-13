using System;

namespace My_Test_App_For_GoAir
{
    interface inter1
    {
        void method();
        //void method1();
    }
    interface inter2
    {
        void method();
    }
    class InterfaceTest : inter1, inter2
    {
        public void method()
        {
            //inter1 inter1 = new InterfaceTest();
            //InterfaceTest InterfaceTest = new inter1();
            Console.WriteLine("Interface Method of class");
        }
        void inter1.method()
        {
            Console.WriteLine("Interface Method of inter1");
        }

        void inter2.method()
        {
            Console.WriteLine("Interface Method of inter2");
        }
    }
}
