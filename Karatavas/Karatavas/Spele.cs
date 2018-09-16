using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Spele
    {
        public void Menu()
        {
            String choice = "";

            while (choice != "exit")
            {
                Console.WriteLine("Ievadiet \"1\" lai saktu speli: ");
                Console.WriteLine("Ievadiet \"exit\" lai izietu no speles: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MainArrayFunction();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }

        private char[] Array = new char[13] { 'p', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'e', 's', 'a', 'n', 'a' };
        private char[] Array2 = new char[13] { 'p', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'e', 's', 'a', 'n', 'a' };


        private void MainArrayFunction()
        {
            int tries = 0;
            int win = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = '_';
            }

            while (tries != 5 && win != 1)
            {
                // Meginajums uztaisit lai while cikls tiek partraukts kad ir uzminets vards.
                /*for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] != '_')
                    {
                        Console.WriteLine("Apsveicu ar uzvaru!");
                        win++;
                    }
                }*/

                char x = Ievade();



                if (x != 'p'
                    && x != 'r'
                    && x != 'o'
                    && x != 'g'
                    && x != 'r'
                    && x != 'a'
                    && x != 'm'
                    && x != 'm'
                    && x != 'e'
                    && x != 's'
                    && x != 'a'
                    && x != 'n'
                    && x != 'a')
                {
                    tries++;

                    if (tries == 5)
                    {
                        Console.WriteLine("Game over");
                    }
                    else
                    {
                        Console.WriteLine("Nepareiza ievade");
                    }
                }

                for (int i = 0; i < Array2.Length; i++)
                {
                    if (x == Array2[i])
                    {
                        Array[i] = Array2[i];
                    }
                }

                for (int i = 0; i < Array.Length; i++)
                {
                    Console.Write(Array[i]);
                }
                Console.WriteLine();

                Console.WriteLine("Kludas 5/" + tries);
            }
        }




        private char Ievade()
        {
            Console.WriteLine("Ievadiet burtu");
            String burts = Console.ReadLine();
            char result = Convert.ToChar(burts);

            return result;
        }
    }
}
