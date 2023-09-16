using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ
{
    public class Animal
    {
        public string color = "White";
        public virtual void eat()
        {

        }
    }
    public class Dog : Animal
    {
        public string color = "Black";
        public void showColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);


        }
    }

        public class Animal1
        {
            public virtual void eat()
            {
                Console.WriteLine("Eating");

            }
        }




        public class Dog1 : Animal1
        {
            public override void eat()
            {
                base.eat();
                Console.WriteLine("Eating Bread");
            }
        }



    
}
