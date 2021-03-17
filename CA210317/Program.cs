using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA210317
{
    class Program
    {
        static Random rnd = new Random();

        static void Main()
        {
            Jelszo();
            Console.ReadKey();
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
