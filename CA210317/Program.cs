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

        static int[] tomb = { 32, 11, 2, 20, 61, 82, 17, 69, 907, 2 };

        static void Main()
        {
            //ProgtetelekSorozatszamitas();
            //ProgtetelekEldontesLinKerKivalasztas();
            ProgtetelekSzelsoertek();

            Console.ReadKey();
        }

        private static void ProgtetelekSorozatszamitas()
        {
            int sum = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                sum += tomb[i];
            } 
            Console.WriteLine($"Tömb elemeinek összege: {sum}");
            Console.WriteLine($"Tömb elemeinek átlaga: {sum/(float)tomb.Length}");

            string[] szavak = { "meg", "szent", "ség", "telenít", "hetetlen", "ség", "eiek", "ért" };
            string con = "";
            for (int i = 0; i < szavak.Length; i++)
            {
                con += szavak[i];
            }
            Console.WriteLine(con);

            long mult = 1;
            for (int i = 0; i < tomb.Length; i++)
            {
                mult *= tomb[i];
            }
            Console.WriteLine("Tömb elemeinek szorzata: {0:N0}", mult);

            Console.WriteLine($"Összeg: {tomb.Sum()}");
            Console.WriteLine($"Átlag: {tomb.Average()}");
        }
        private static void ProgtetelekEldontesLinKerKivalasztas()
        {
            //Eldöntés:
            //INPUT -> sorozat
            //KÉRÉS <T> tulajdonságnak megfelel-e
            //OUTPUT bool

            //pl.: T:: megtalálható benne a 66-os szám
            int i = 0;
            while (i < tomb.Length && tomb[i] != 11)
            {
                i++;
            }

            if (i < tomb.Length) Console.WriteLine("benne van");
            else Console.WriteLine("nincs benne");

            Console.WriteLine("----------------------");
            //Lineáris Keresés: (rendezetlen adatszerkezetekre alkalmazom)
            //INPUT -> sorozat
            //KÉRÉS -> adott elem szerepel-e, és ha igen, akkor hol?
            //OUTPUT index
            i = 0;
            while (i < tomb.Length && tomb[i] != 69)
            {
                i++;
            }

            if (i < tomb.Length)
            {
                Console.WriteLine("benne van");
                Console.WriteLine($"idenx: {i}"); //<-
                Console.WriteLine($"hely: {i + 1}");
            }
            else
            {
                Console.WriteLine("nincs benne");
                Console.WriteLine("index: -1"); //<-
            }

            Console.WriteLine("----------------------");
            //Kiválasztás: 100%-ra tudom, hogy benne van, de azt nem, hogy hol
            //INPUT -> sorozat
            //KÉRÉS -> hol van a keresett elem
            //OUTPUT index
            i = 0;
            while (tomb[i] != 20)
            {
                i++;
            }
            Console.WriteLine($"index: {i}");


            int linker = Array.IndexOf(tomb, 2);
            Console.WriteLine(linker);

            bool eldontes = tomb.Contains(2000);
            Console.WriteLine(eldontes);

        }
        private static void ProgtetelekSzelsoertek()
        {
            //rendezetlen adatsoron értelmezzük a szélsőérték tételeket

            //mimimum VALUE -> legkisebb érték
            //minimum INDEX -> legkisebb érték indexe <--
            //minimum LOCATION -> lekgisebb érték helye (index + 1)
            //maximum VALUE -> legnagyobb érték
            //maximum INDEX -> legnagyobb érték indexe <--
            //maximum LOCATION -> legnagyobb érték helye (index + 1)


            int mini = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] < tomb[mini]) mini = i;
            }

            Console.WriteLine($"mimimum value: {tomb[mini]}");
            Console.WriteLine($"minimum index: {mini}");
            Console.WriteLine($"minimum location: {mini + 1}");

            Console.WriteLine("-----------------------------");

            int maxi = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[maxi]) maxi = i;
            }

            Console.WriteLine($"maximum value: {tomb[maxi]}");
            Console.WriteLine($"maximum index: {maxi}");
            Console.WriteLine($"maximum location: {maxi + 1}");

            Console.WriteLine("-----------------------------");

            Console.WriteLine("minimum: " + tomb.Min());
            Console.WriteLine("maximum: " + tomb.Max());
            Console.WriteLine("minindex: " + Array.IndexOf(tomb, tomb.Min()));
            Console.WriteLine("maxindex: " + Array.IndexOf(tomb, tomb.Max()));
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
