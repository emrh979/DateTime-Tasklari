using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts = new TimeSpan();
            DateTime vaxt = DateTime.Now;



            /* Console.WriteLine("Dogum tarixim: ");
             DateTime dogumTarixi = new DateTime(2006, 10, 14);
             Console.WriteLine(dogumTarixi.ToString("dd.MM.yyyy"));
             Console.WriteLine("Heftenin gunu: ");
             Console.WriteLine(dogumTarixi.DayOfWeek);
             Console.WriteLine("Nece gundu yasiyiram: ");
             ts = vaxt - dogumTarixi;
             Console.WriteLine(Math.Floor(ts.TotalDays));*/

            Console.Write("Tarixi qeyd et(yyyy-MM-dd): ");
            string dt =Console.ReadLine();
            DateTime daxilEdilen = Convert.ToDateTime(dt);
            Console.WriteLine(daxilEdilen);
            if (vaxt > daxilEdilen) 
            {
                Console.WriteLine("Hadise olub kecib!!!");
            }
            else
            {
                ts = daxilEdilen - vaxt;
                Console.WriteLine(Math.Floor(ts.TotalDays) + " gun qalib");
            }



        }
    }
}
