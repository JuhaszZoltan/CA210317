using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA210317
{
    class Program
    {
        static Random rnd = new Random();

        static void Main()
        {
            Fealdatok05_01_3();
            Console.ReadKey();
        }

        private static void Fealdatok05_01_3()
        {
            Console.CursorVisible = false;
            int csillagPont = 0;
            int kukacPont = 0;

            for (int k = 0; k < 3; k++)
            {
                int csillag = 0;
                int kukac = 0;
                while (csillag <= 50 && kukac <= 50)
                {
                    Console.Clear();
                    Console.WriteLine($"{k + 1}. futam:");

                    csillag += rnd.Next(1, 4);
                    for (int i = 0; i < csillag; i++) Console.Write(' ');
                    Console.Write('*');

                    Console.Write("\n\n");

                    kukac += rnd.Next(1, 4);
                    for (int i = 0; i < kukac; i++) Console.Write(' ');
                    Console.Write('@');

                    Thread.Sleep(100);
                }

                if (csillag == kukac) Console.WriteLine("\n\ndöntetlen!");
                else if (csillag > kukac)
                {
                    Console.WriteLine("\n\n* nyert");
                    csillagPont++;
                }
                else
                {
                    Console.WriteLine("\n\n@ nyert!");
                    kukacPont++;
                }

                Console.WriteLine($"\nÖsszesítés:\n@: {kukacPont} pont\n*: {csillagPont} pont");

                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            }
            Console.Clear();
            Console.WriteLine(":::VÉGEREDMÉNY:::");
            Console.WriteLine($"@: {kukacPont} pont\t|||\t*: {csillagPont} pont");
            if(csillagPont == kukacPont) Console.WriteLine("döntetlen");
            else if (csillagPont > kukacPont) Console.WriteLine("* győzött!!!!44négy!4!!");
            else Console.WriteLine("@ győzött!!!!44négy!4!!");


        }
        private static void Fealdatok05_01_2()
        {
            Console.CursorVisible = false;
            int x = 0;
            int y = 0;

            while (x <= 50 && y <= 50)
            {
                Console.Clear();

                //*
                x += rnd.Next(1, 4);
                for (int i = 0; i < x; i++) Console.Write(' ');
                Console.Write('*');

                Console.Write("\n\n");

                //@
                y += rnd.Next(1, 4);
                for (int i = 0; i < y; i++) Console.Write(' ');
                Console.Write('@');

                Thread.Sleep(300);
            }

            if (x == y) Console.WriteLine("\n\ndöntetlen!");
            else if (x > y) Console.WriteLine("\n\n* nyert");
            else Console.WriteLine("\n\n@ nyert!");
        }
        private static void Fealdatok05_01_1()
        {
            int x = 0;

            while (x <= 50)
            { 
                Console.Clear();
                //Console.BackgroundColor = ConsoleColor.Green;
                for (int i = 0; i < x; i++) Console.Write(' ');
                //Console.ResetColor();
                Console.Write("*");
                Thread.Sleep(300);
                x += rnd.Next(1, 4);
            }
        }
        private static void Fealdatok05_01_0()
        {
            int x = 0;

            while (x <= 50)
            {              
                Console.WriteLine(x);
                x += rnd.Next(1, 4);
            }
        }
        private static void Jelszo()
        {
            string jelszo = "PassWord123";

            int c = 0;
            string bekert;
            do
            {
                Console.Write("Írd be a jelszót: ");
                bekert = Console.ReadLine();
                c++;
            } while (bekert != jelszo && c < 3);

            if (bekert == jelszo) Console.WriteLine("sikeresen bejelentkeztél!");
            else Console.WriteLine("túl sok próbálkozás, próbáld később");           
        }
        private static void FWhileVsDoWhile()
        {
            int x = 10;
            Console.WriteLine("while");
            while (x < 10)
            {
                Console.WriteLine("Juhasz Zoltan");
            }
            //--------------------------
            Console.WriteLine("do while");
            int y = 10;
            do
            {
                Console.WriteLine("Juhasz Zoltan");
            } while (y < 10);
        }
        private static void FImplicitEsExplicitTipus()
        {
            int x = 10;

            //implicit típusmegjelölés
            var d1 = new DateTime(1990, 07, 11);

            //explicit típusmegjelölés
            DateTime d2 = new DateTime(1990, 07, 11);

            var t = new int[10];
            var rnd = new Random();
            var ts = new TimeSpan(10, 10, 10);
        }
    }
}
