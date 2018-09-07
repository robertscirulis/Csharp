using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Uzdevums
    {

        public void Hack()
        {
            GarumaParbaude();
        }

        private void GarumaParbaude()
        {
            Console.WriteLine("Ievadiet Vardu:");
            String pasreizejais = Console.ReadLine();

            if (pasreizejais.Length >= 1 && pasreizejais.Length <= 13)
            {
                Console.WriteLine("Viss ir ok");
            }
            else
            {
                Console.WriteLine("Nepareiza ievade");
            }
        }

        private void Izvelne()
        {
            int c = 11;

            switch (c)
            {
                case 0:
                    Console.WriteLine("vii");
                    break;
                case 1:
                    Console.WriteLine("vii2");
                    break;
                default:
                    Console.WriteLine("nee");
                    break;
            }
        }

        public void Menu()
        {
            String choice = "";

            while (choice != "iziet")
            {
                Console.WriteLine("Ievadiet Vardu:");
                choice = Console.ReadLine();
            }
        }


        public void Cikli()
        {
            int i = 0;
            String star = "*";
            while (i < 4)
            {
                Console.WriteLine(star);
                star = star + '*';
                i++;
            }
        }

        public void Menu2()
        {
            String choice = "";

            while (choice != "iziet")
            {
                Console.WriteLine("Ievadiet Vardu:");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("vii");
                        break;
                    case "2":
                        Console.WriteLine("vii2");
                        break;
                    case "3":
                        Console.WriteLine("vii3");
                        break;
                    case "iziet":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }
    }
}
