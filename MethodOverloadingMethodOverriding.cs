using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ
{
    internal class MethodOverloadingMethodOverriding

    {
        public int Addition(int a, int b)
        {
            return a + b;

        }
        public int Addition(int a, int b, int c)
        {
            return a + b + c;

        }
        public double Addition(int a, double b)
        {
            return a + b;
        }
        public double Addition(double a, double b)
        {
            return a + b;
        }
    }
        class BaseClass
        {
            public virtual int Add(int a,int b) 
            { 
            return a + b;
            } 
            
            
        }
        class ChildClass: BaseClass
        {
            public override int Add(int a,int b)
            {
                return a + b;   
            }
        }
        public class Parent
        {
        public virtual void Show()
        {
        Console.WriteLine("Show Addition");

        }
        public virtual void Hide()
        {
            Console.WriteLine("Hide Addition");

        }


        }
}

    

