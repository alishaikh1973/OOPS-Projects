using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ
{
    public class Movie
    {
        private int M_id, Totaln = 0;
        private static int count;
        private string Mname, type;
        private double Price = 0;
        private int NoofTkt = 15;


        public Movie(int M_id, string Mname, double Price, int NoofTkt)
        {
            count++;
            this.M_id = count;
            this.Mname = Mname;
            this.Price = Price;
            this.NoofTkt = NoofTkt;
        }



            public string Display()
            {
                return $"MovieID={M_id}, Name={Mname}, Price={Price},No.of Ticket={NoofTkt}";


            }
            public int FindTicket()
            {
                return NoofTkt;
            }
            public double Findcost(int choice)
            {
                switch (choice)
                {
                    case 1:
                        Price = Totaln * 100;
                        break;
                    case 2:
                        Price = Totaln * 200;
                        break;
                    case 3:
                        Price = Totaln * 300;
                        break;
                    default:
                        break;
                }
                return Price;
            }
            public string BookTicket(int num)
            {
                string msg;
                int choice1 = 0;
                Totaln = num;
                if (num > NoofTkt)
                {
                    msg = "Error:Ticket Not Available";
                }
                else
                {
                    NoofTkt -= num;
                    msg = $"{num}Ticket booked";
                    this.Findcost(choice1);
                }
                return msg ;
            }
        }

    }



