using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ
{
    internal class Demonitisation
    {
        public static void Main(string[] args)
        {
            int[] notes = new int[] { 1000, 500, 200, 100, 50, 20, 10, };
            Console.WriteLine("Enter the amount");
            int temp;
            int amt = Convert.ToInt32(Console.ReadLine());
            if (amt > 0)
            {
                temp = amt;
                for (int i = 0; i < notes.Length; i++)
                {
                    int total_notes = temp / notes[i];
                    Console.WriteLine($"notes[i], notes given {total_notes}");
                    temp = temp % notes[i];
                }
            }






        }


    }
}

