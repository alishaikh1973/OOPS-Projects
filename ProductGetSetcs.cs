using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ
{
    public class ProductGetSet
    {
        private int id;
        private string name;
        private double price;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public double Price
        {
            get { return price; }
            set { price = value; }

        }
        public string Print()
        {
            return $"Product {id}, {name} , {price}";
        }
    }
}
    




