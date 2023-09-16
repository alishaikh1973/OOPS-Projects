using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ
{
    internal class Car
    {
        private string Companyname, modelname;
        private int cost;


        public Car(string companyname, string modelname, int cost)
        {
            this.Companyname = companyname;
            this.modelname = modelname;
            this.cost = cost;
        }
        public void Accept()
        {
            Companyname = "hyundia";
            modelname = "i10";
            cost = 800000;
            
        }
    }
}
