using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class A
    {
        static void Main(string[] args)
        {
            C c = new C("M");
            D d = new D("y", "s");
            E e = new E("k", "i", "v");


            B b = new B();
            b.String(c);
            b.String(d);
            b.String(e);
        }
    }




    class B
    {
        public void String(C c)
        {
            c.String();
        }
    }




    class C
    {
        public string FirstString { get; set; }
        public C(string firstString)
        {
            FirstString = firstString;
        }
        public virtual void String()
        {
            Console.WriteLine(FirstString);
        }


    }


    class D : C
    {
        public string SecondString;
        public D(string firstString, string secondString) : base(firstString)
        {
            SecondString = secondString;
        }
        public override void String()
        {
            base.String();
            Console.WriteLine(SecondString);
        }
    }


    class E : C
    {
        public string SecondString;
        public string ThirdString;
        public E(string firstString, string secondString, string thirdString) : base(firstString)
        {
            SecondString = secondString;
            ThirdString = thirdString;
        }
        public override void String()
        {
            base.String();
            Console.WriteLine(SecondString);
            Console.WriteLine(ThirdString);
        }
    }
}