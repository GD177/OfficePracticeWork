using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Test_App_For_GoAir
{
    class A
    {
        public A(int a)
        {
            Console.WriteLine("A Constructor with parameter");
        }
        public A()
        {
            Console.WriteLine("A Constructor");
        }

        public virtual void method()
        {
            Console.WriteLine("Inside A method");
        }
        public void method1(int a, int b)
        {
            Console.WriteLine("Inside A method");
        }
    }
    class B : A
    {
        //public B(int a) : base(a)
        //{
        //    Console.WriteLine("B Constructor inherting parameterized constructor of A");
        //}
        public B(int a)
        {
            Console.WriteLine("B Constructor with parameter");
        }
        public B()
        {
            Console.WriteLine("B Constructor");
        }
        //public new virtual void method()
        //{
        //    Console.WriteLine("Inside B method");
        //}
        public override void method()
        {
            Console.WriteLine("Inside B method");
        }
    }
    class C : B
    {
        public C() : base(2)
        {
            Console.WriteLine("C Constructor");
        }
        public new void method()
        {
            Console.WriteLine("Inside C method");
        }
        //public override void method()
        //{
        //    Console.WriteLine("Inside C method");
        //}
    }
    class newA
    {
        public virtual void method()
        {
            Console.WriteLine("Inside newA method");
        }
    }
    class newB : newA
    {
        public override void method()
        {
            Console.WriteLine("Inside newB method");
        }
    }

    class newC : newA
    {
        public new void method()
        {
            Console.WriteLine("Inside newC method");
        }
    }
}
