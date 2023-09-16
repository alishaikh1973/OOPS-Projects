using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Inheritance
{
   public  class Mobile
        {
            protected string Memory ;
        public Mobile()
        {
                
        }
        public void Price()
            {
                Console.WriteLine(5000);
            }
            public virtual void Show()
            {
                Console.WriteLine(Memory);
            }
        }
      public  class Apple : Mobile
        {
            string CameraPixel = "3pxl";
            public override void Show()
            {
                Console.WriteLine(Memory);
            }
        }
              public  class IphonePro : Mobile
                {
                    public override void Show()
                    {
                        Console.WriteLine(Memory);
                    }
                }

    
}
    

