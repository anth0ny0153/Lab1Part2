using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first chosen date in year/day/month format(1997/2/3)");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second chosen date in year/day/month format(1997/2/3");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            TimeSpan subtract = date2 - date1;

            Console.WriteLine("Days between two dates = " + subtract.TotalDays.ToString());
            Console.WriteLine("Hours between two dates = " + subtract.TotalHours.ToString());
            Console.WriteLine("Minutes between two dates = " + subtract.TotalMinutes.ToString());

            Console.ReadKey();
        }
    }
}
