using System;
using System.Collections.Generic;
using System.Globalization;
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
            DateTime indikiVaxt = DateTime.Now;

            void Task1()
            {
                Console.WriteLine("Dogum gununuzu daxil edin(yyyy-MM-dd)");
                string elaveEt = Console.ReadLine();
                DateTime dogumGunu = Convert.ToDateTime(elaveEt);

                Console.Write($"Doguldugunuz gun: ");
                Console.WriteLine(dogumGunu.DayOfWeek);
            }

            void Task2()
            {
                Console.WriteLine("Dogum gununuzu daxil edin(yyyy-MM-dd)");
                string elaveEt = Console.ReadLine();
                DateTime dogumGunu = Convert.ToDateTime(elaveEt);

                ts = indikiVaxt - dogumGunu;
                Console.WriteLine($"{Math.Floor(ts.TotalDays)} gundur yasayirsiniz...");
            }
            void Task3()
            {
                Console.WriteLine($"Bu gun: {indikiVaxt.DayOfWeek}");
                indikiVaxt = indikiVaxt.AddDays(40);
                Console.WriteLine($"40 gun sonraki gun: {indikiVaxt.DayOfWeek}");
            }

            void Task4() 
            {
                Console.Write("Gunu daxil edin:");
                int daxilGun = int.Parse(Console.ReadLine());


                Console.Write("Ayi daxil edin:");
                int daxilAy = int.Parse(Console.ReadLine());


                Console.Write("Ili daxil edin:");
                int daxilIl = int.Parse(Console.ReadLine());


                DateTime verilenVaxt = new DateTime(Convert.ToInt32(daxilIl), Convert.ToInt32(daxilAy), Convert.ToInt32(daxilGun));
                Console.WriteLine("Tarixiniz: " + verilenVaxt.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));

                if (verilenVaxt == indikiVaxt)
                {
                    Console.WriteLine(true);
                }
                else  
                {
                    Console.WriteLine(false); 
                }

            }

            void Task6() 
            {
                Console.WriteLine("Birinci tarixi daxil edin(yyyy-MM-dd)");
                string elaveEt = Console.ReadLine();
                DateTime tarix1 = Convert.ToDateTime(elaveEt);

                Console.WriteLine("Ikinci tarixi daxil edin(yyyy-MM-dd)");
                string elaveEt2 = Console.ReadLine();
                DateTime tarix2 = Convert.ToDateTime(elaveEt2);

                 ts = tarix2 - tarix1;
                Console.WriteLine($"Bu tarixler arasinda {ts.TotalDays} gun ferq var!!!");
            }
            
            void Task8() 
            {
                Console.WriteLine("Birinci tarixi daxil edin(yyyy-MM-dd HH:mm)");
                string elaveEt = Console.ReadLine();
                DateTime tarix1 = Convert.ToDateTime(elaveEt);

                Console.WriteLine("Ikinci tarixi daxil edin(yyyy-MM-dd HH:mm)");
                string elaveEt2 = Console.ReadLine();
                DateTime tarix2 = Convert.ToDateTime(elaveEt2);

                ts = tarix2 - tarix1;
                Console.WriteLine($"Baslama vaxti: {tarix1}\nBitme vaxti: {tarix2}\nHadise muddeti: {Math.Floor(ts.TotalHours)})");

            }

            Task8();
        }
    }
}
