using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Matematika
    {
        public void Kalkulators()
        {
            String choice = "";

            while (choice != "iziet")
            {
                Console.WriteLine("Ievadiet 1 lai saskaititu,2 lai atnemtu, 3 lai kapinatu, 'iziet' to get out of here");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Saskaitit();
                        break;
                    case "2":
                        Atnemsana();
                        break;
                    case "3":
                        Kapinasana();
                        break;
                    case "iziet":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }


        private void Saskaitit()
        {
            int a, b;

            a = Parveidosana();
            b = Parveidosana();

            int rezultats = a + b;
            Console.WriteLine(rezultats);
        }

        private void Atnemsana()
        {
            int a, b;

            a = Parveidosana();
            b = Parveidosana();

            int rezultats = a - b;
            Console.WriteLine(rezultats);
        }

        private void Kapinasana()
        {
            int skaitlis = Parveidosana();
            int pakape = Parveidosana();

            int rezultats = 1;
            for (int i = 0; i < pakape; i++)
            {
                rezultats = rezultats * skaitlis;
            }
            Console.WriteLine(rezultats);
        }

        private int Parveidosana()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String virkne = Console.ReadLine();
            int result = Convert.ToInt16(virkne);
            return result;
        }
    }
}
