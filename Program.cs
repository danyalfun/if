using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Task1()
        {
            int x;
            Console.WriteLine("enter num");
            x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                if (x % 2 == 0)
                    Console.WriteLine("num is hiyuvi and zugi");
                else
                    Console.WriteLine("num is hiyuvi and i zugi");
            }
            else if (x < 0)
                Console.WriteLine("num is shlili");
            else
                Console.WriteLine("num is efes");
                
        }
        static void Task2()
        {
            double price;
            Console.WriteLine("How much kutsh do you consume");
            double usage = double.Parse(Console.ReadLine());
            Console.WriteLine("Are you a business");
            bool bussy = bool.Parse(Console.ReadLine());
            if (bussy == true)
            {
                if (usage <= 300)
                    price = 0.5 * 1.15;
                else if (usage > 301 && usage < 600)
                    price = 0.7 * 1.15;
                else
                    price = 1 * 1.15;
            }
            else
            {
                if (usage <= 300 )
                    price = 0.5 * 1.05;
                else if (usage > 301 && usage < 600)
                    price = 0.7 * 1.05;
                else
                    price = 1 * 1.05;
            }
            
            Console.WriteLine("The price is " + price);

        }
        static void Task3()
        {
            double price;
            Console.WriteLine("enter if you in city");
            bool city = bool.Parse(Console.ReadLine());
            string spetial;
            spetial = Console.ReadLine();
            if (spetial == "gimli")
            {
                if (city == true)
                    price = 6 * 0.7;
                else
                    price = 12 * 0.7;
            }
            else if (spetial == "student")
            {
                if (city == true)
                    price = 6 * 0.8;
                else
                    price = 12 * 0.8;
            }
            else
            {
                if (city == true)
                    price = 6 ;
                else
                    price = 12 ;
            }
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();

        }
    }
}
