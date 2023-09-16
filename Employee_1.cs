using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ
{
    internal class EmployeeSal

    {
        private int id;
        private string name;
        private double salary, hra, da, ta, pf, gross;

        public EmployeeSal()
        {
            id = 1;
            name = " ";
            salary = 0; hra = 0; da = 0; ta = 0; pf = 0; gross = 0;


        }
        public EmployeeSal(int id, string n, double Sal)
        {
            this.id = id;
            this.name = n;
            this.salary = Sal;

              void Accept(int id, string name, double salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;
            }
             void CalculateSalary()
            {
                hra = salary * 0.40;
                da = salary * 0.20;
                ta = salary * 0.10;
                pf = salary * 0.12;
                gross = (salary + hra + da + ta) - pf;
            }

        }
    }
}
