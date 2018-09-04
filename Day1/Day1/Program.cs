using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say something");
            int veselsSkaitlis = 5;
            double arKomatu = 4.5;
            String simboluVirkne = "Hello?";
            String simboluVirkne2 = "Is it me you're looking for?";
            String simboluVirkne3 = "'Cause I wonder where you are";
            char simbols = 'g';
            bool patiessVaiNe = true;

            veselsSkaitlis = 6;

            /*Console.WriteLine("Ievadiet skaitli");
            simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            Console.WriteLine("Ievadiet skaitli 2");
            simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis2 = Convert.ToInt16(simboluVirkne);
            Console.WriteLine(jaunaisSkaitlis + jaunaisSkaitlis2);*/


            // <
            // >
            // ==
            // !=
            // <=
            // >=

            Console.WriteLine("Ievadiet skaitli");
            simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            if (jaunaisSkaitlis > 5 && jaunaisSkaitlis < 10)
            {
                Console.WriteLine("##");
            }
            else {
                Console.WriteLine("#");
            }


            

            Console.ReadLine();
            
            /*Console.WriteLine(simboluVirkne);

            Console.ReadLine();
            Console.WriteLine(simboluVirkne2);
            Console.ReadLine();
            Console.WriteLine(simboluVirkne3);
            Console.ReadLine();*/
        }
    }
}
