using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.AbstractProgram
{
    abstract public class Shape
    {
        public Shape()
        {

        }
        public abstract string Draw(string name);
        public abstract void Area();
        public string Display()
        {
            return "This is shape class";
        }

    }
    public class Rectangle :Shape
    {
        private int len;
        private int b;
        private double area;

        public Rectangle(int len, int b) 
        {
            this.len = len;
            this.b = b;
        }
        public override void Area()
        {
            area = len*b;
        }
        public override string Draw(string name) 
        {
            return name;
        }
        public string Print()
        {
            return $"Area of rectangle is = {area}";
        }
    }

}

