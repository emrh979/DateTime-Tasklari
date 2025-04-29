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
            DateTime vaxt = DateTime.Now;

           
            

            Console.WriteLine(vaxt.ToString(""));
            Console.WriteLine(vaxt.ToLongDateString());
            Console.WriteLine(vaxt.ToLongTimeString());
            Console.WriteLine(vaxt.AddDays(10));

            TimeSpan ts = new TimeSpan();
            


            Console.WriteLine("Dogum tarixim: ");
            DateTime dogumTarixi = new DateTime(2006, 10, 14);
            Console.WriteLine(dogumTarixi.ToString("dd.MM.yyyy"));
            Console.WriteLine("Heftenin gunu: ");
            Console.WriteLine(dogumTarixi.DayOfWeek);
            Console.WriteLine("Nece gundu yasiyiram: ");
            ts = vaxt - dogumTarixi;
            Console.WriteLine(Math.Floor(ts.TotalDays));


        }
    }
}
