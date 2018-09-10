using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5uzdevums
{
    class Daudzsturi
    {
        private int b = 0;
        private int c = 0;

        public void Interface()
        {
            Menu();
        }

        private void Menu()
        {
            String choice = "";

            while (choice != "0")
            {

                Console.WriteLine("1-ievadiet sturu skaitu, 2-ievadiet malu garumu, 3-paradit malu skaitu/garumu un kas par figuru, 4-Perimetrs, 0-iziet");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MaluSkaitaParb();
                        break;
                    case "2":
                        MaluGarums();
                        break;
                    case "3":
                        Console.WriteLine("Malu skaits = " + b);
                        Console.WriteLine("Malu garums = " + c);
                        FigurasVeids();
                        break;
                    case "4":
                        Perimetrs();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }


        private void FigurasVeids()
        {           
            switch (b)
            {
                case 3:
                    Console.WriteLine("Figura = Trijsturis");
                    break;
                case 4:
                    Console.WriteLine("Figura = Cetrsturis");
                    break;
                case 5:
                    Console.WriteLine("Figura = Piecsturis");
                    break;
                default:
                    Console.WriteLine("Nepareiza ievade");
                    break;                    
            }
        }



        private void Perimetrs()
        {
            int skaits = b;
            int garums = c;

            int result = skaits * garums;

            Console.WriteLine("Figuras perimetrs = " + result);
        }

        // parbauda vai ievadita vertiba sakrit ar int 3, 4 vai 5 un tad aktivize MaluSkaits() funkciju kura tiek padota talak ievadita vertiba.
        private void MaluSkaitaParb() 
        {            
            b = Parveidosana();
            int vertiba = b;
            if (b >= 3 && b <= 5)
            {                
                MaluSkaits(vertiba);
            } else
            {
                Console.WriteLine("Nepareiza ievade");
            }
        }

        private int MaluSkaits(int vertiba)
        {
            b = vertiba;
            return b;

        }

        private int MaluGarums()
        {
            c = Parveidosana();
            return c;
        }


        private int Parveidosana()
        {
            Console.WriteLine("Ievadiet skaitli");
            String virkne = Console.ReadLine();
            int result = Convert.ToInt16(virkne);
            return result;
        }
    }
}