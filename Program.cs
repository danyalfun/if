using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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
        static void Task4() 
        {
            int age;
            Console.WriteLine("enter your age");
            age = int.Parse(Console.ReadLine());
            double prie = 0;
            if (age <= 18 && age > 0)
            {
                bool student;
                Console.WriteLine("do you a student");
                student = bool.Parse(Console.ReadLine());
                prie = 120;
                if (student == true)
                    prie *= 0.8;
                
            }
            else if (age < 60 && age > 19)
            {
                prie = 180;
                bool vip;
                Console.WriteLine("do you vip");
                vip = bool.Parse(Console.ReadLine());
                if (vip == true)
                    prie *= 1.3;

            }
            else
            {
                prie = 150;
                bool gimle;
                Console.WriteLine("do you a gimle from zhl");
                gimle = bool.Parse(Console.ReadLine());
                if (gimle == true)
                    prie -= prie * 0.15;

            }
            Console.WriteLine("you need to pay: " +  prie);    
        }
        static void Task5()
        {
            string room;
            double preis = 0;
            bool endweek;
            Console.WriteLine("you want swit or reg");
            room = Console.ReadLine();
            Console.WriteLine("do you came at weed end");
            endweek = bool.Parse(Console.ReadLine());
            bool friend;
            Console.WriteLine("do you friend");
            friend = bool.Parse(Console.ReadLine());
            if (room == "swit")
            {
                preis = 400;
                if (endweek == true)
                    preis += preis * 0.1;
                if (friend == true)
                    preis -= preis * 0.15;
            }
            else
            {
                preis = 700;
                if (endweek == true)
                    preis += preis * 0.1;
                if (friend == true)
                    preis -= preis * 0.15;
            }
            Console.WriteLine("you need to pay: " + preis);

        }
        static void Task6()
        {
            int age;
            Console.WriteLine("enter your age");
            age = int.Parse(Console.ReadLine());
            double prie = 0;
            if (age <= 12 && age >= 0)
            {
                bool shabt;
                Console.WriteLine("do you came at shabt");
                shabt = bool.Parse(Console.ReadLine());
                prie = 50;
                if (shabt == true)
                    prie += 10;

            }
            else if (age < 18 && age >= 13)
            {
                prie = 70;
                bool member;
                Console.WriteLine("do you member");
                member = bool.Parse(Console.ReadLine());
                if (member == true)
                    prie *= 0.8;

            }
            else
            {
                prie = 100;
                bool vip;
                Console.WriteLine("do you a vip");
                vip = bool.Parse(Console.ReadLine());
                if (vip == true)
                    prie += prie * 0.3;

            }
            Console.WriteLine("you need to pay: " + prie);
        }
       
        static void Task7()
        {
            int age;
            Console.WriteLine("enter your age");
            age = int.Parse(Console.ReadLine());
            double prie = 0;
            if (age <= 24 && age >= 0)
            {
                bool spurt;
                Console.WriteLine("do you spurt car");
                spurt = bool.Parse(Console.ReadLine());
                prie = 600;
                if (spurt == true)
                    prie += prie * 0.25;

            }
            else if (age < 25 && age >= 50)
            {
                prie = 450;
                bool acseddnt;
                Console.WriteLine("do you was in a acseddnt last year");
                acseddnt = bool.Parse(Console.ReadLine());
                if (acseddnt == true)
                    prie += prie * 0.2;

            }
            else
            {
                prie = 400;
                bool regular;
                Console.WriteLine("do you a regular car");
                regular = bool.Parse(Console.ReadLine());
                if (regular == true)
                    prie -= prie * 0.1;

            }
            Console.WriteLine("you need to pay: " + prie);
        }
        static void Task8()
        {
    int num;
    Console.WriteLine("enter a number");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        if (num % 4 == 0)
            Console.WriteLine("number devedes by 4");
        else
            Console.WriteLine("number not devedes by 4 and zogi");
    }
    else
    {
        Console.WriteLine("number is i zogi");
    }
}
      


        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
        }
    }
}

