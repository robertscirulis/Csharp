using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Program
    {
        static void Main(string[] args) {

            piemers();
            //piemers();
            Console.WriteLine("Ievadiet skaitli");
            String simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            Console.WriteLine("Ievadiet skaitli 2");
            String simboluVirkne2 = Console.ReadLine();
            int jaunaisSkaitlis2 = Convert.ToInt16(simboluVirkne2);

            int summa = Saskaitisana(jaunaisSkaitlis, jaunaisSkaitlis2);
            Console.WriteLine(summa);

            Console.WriteLine(Saskaitisana(jaunaisSkaitlis, jaunaisSkaitlis2));

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

        static int Saskaitisana(int skaitlis1, int skaitlis2)
        {
            int rezultats = skaitlis1 + skaitlis2;
            return rezultats;

        }
    }
}
