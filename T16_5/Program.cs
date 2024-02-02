using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T16_5
{
    internal class Program
    {
        public static DateTime Time(string num)
        {
            Write($"Enter {num} time: ");
            DateTime time = DateTime.Parse(ReadLine());
            return time;
        }
        static void Main(string[] args)
        {
            try
            {
                //Task 1
                Write("Enter number of visits: ");
                int n = Convert.ToInt32(ReadLine());
                WriteLine();
                VisitCounter[] visitCounter = new VisitCounter[n];
                for(int i = 0; i < visitCounter.Length; i++)
                {
                    Write("Enter website address: ");
                    string web_address = ReadLine();
                    Write("Enter IP: ");
                    string ip = ReadLine();
                    Write("Enter browser: ");
                    string browser = ReadLine();
                    Write("Enter date of visit: ");
                    DateTime visit_date = DateTime.Parse(ReadLine());
                    //Write("Enter time of visit: ");
                    DateTime visit_time = Time("");
                    visitCounter[i] = new VisitCounter(web_address, ip, browser, visit_date, visit_time);
                    WriteLine();
                }
                foreach(var elem in visitCounter)
                {
                    elem.Output();
                    WriteLine();
                }
                DateTime time_1 = Time("first");
                DateTime time_2 = Time("second");
                WriteLine();
                foreach (var elem in visitCounter)
                {
                    Write($"From {time_1} to {time_2} u have these visits: \n");
                    if (time_1 < elem.Visit_date & time_2 > elem.Visit_date) { elem.Output(); }
                    else { WriteLine("None"); break; }
                    WriteLine();
                }



            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
