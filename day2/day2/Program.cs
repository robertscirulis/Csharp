using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {

            piemers();
            //piemers();

            //Saskaitisana();

            int robeza = SkaitlaIevade();
            Zvaigzne(robeza);
            /*piemers2(3, 5);
            
            int skaitlis = piemers3();
            Console.WriteLine(skaitlis);*/

            Console.ReadLine();

        }



        static void piemers()
        {
            {

                /*for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hello World!");
                }

                for (int i = 4; i > -1; i--)
                {
                    Console.WriteLine(i);
                }

                int j = 0;
                while (j < 5)
                {
                    Console.WriteLine(j);
                    j++;
                }

                j = 0;

                do
                {
                    Console.WriteLine(j);
                    j++;
                } while (j < 5);

                Console.ReadLine();*/

                /* String star = "*";

                 for (int i = 0; i < 4; i++)
                 {
                     Console.WriteLine(star);
                     star = star + '*';
                 }

                 Console.ReadLine();*/

            }
        }

        static void piemers2(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int piemers3()
        {
            int rezultats = 6 + 8;

            return rezultats;
        }

        static void Saskaitisana()
        {

            int a;
            int b;
            a = SkaitlaIevade();
            b = SkaitlaIevade();

            int summa = a + b;

            Console.WriteLine(summa);

        }

        static int SkaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli");
            String simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            return jaunaisSkaitlis;
        }

        static void Zvaigzne(int robeza)
        {
            String star = "*";
            for (int i = 0; i < robeza; i++)
            {
                Console.WriteLine(star);
                star = star + '*';
            }
        }

    }
}
