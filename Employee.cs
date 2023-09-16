using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ
{
    internal class EmployeeSalary
    {
        private int Eid, salary;
        private string name, department;
        public void AcceptData(int id, int sal, string n, string dept)
        {
            Eid = id;
            salary = sal;
            name = n;
            department = dept;

        }

        public string PrintData()
        {
            return $"{Eid} {salary} {name} {department}";

        }


    }

}


    

