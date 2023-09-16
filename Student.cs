using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ
{
    internal class GetSetStudent
    {
        private int rollno, percentage;
        private string name, branch;
        public void AcceptData(int rn, int per, string n, string br)
        {
            rollno = rn;
            percentage = per;
            name = n;
            branch = br;
            
        }

        public string PrintData()
        {
            return $"{rollno} {percentage} {name} {branch}";

        }
        
        

        
    

    }

}

