using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSPROJECT_TQ
{
    internal class StudentMarks
    {
        private string Studentname;
        private int sub1, sub2, sub3;
        private int totalmarks;
        private double Per;
           
        public void AcceptData(string sname, int Eng, int Math, int Phy )
        {
            this.Studentname= sname;
            this.sub1=Eng; 
            this.sub2=Math;
            this.sub3=Phy;
        }
        public void CalculatePer()
        {
            totalmarks = sub1 + sub2 + sub3 ;
            Per = ((totalmarks * 300) / 100);
        }

        public string PrintData()
        {
            return $"{Studentname} {sub1} {sub2} {sub3}";

        }
        





    }

}


    

