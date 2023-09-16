using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ
{
    internal class Book
    {
        private int bookid, price;
        private string name, authorname;
        public void AcceptData(int id, int pr, string n, string aname)
        {
            bookid = id;
            price = pr;
            name = n;
            authorname = aname;

        }

        public string PrintData()
        {
            return $"{bookid} {price} {name} {authorname}";

        }


    }

}


    

