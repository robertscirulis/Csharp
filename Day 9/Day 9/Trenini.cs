using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class Trenini
    {
        public void Menu()
        {
            String choice = "";

            while (choice != "iziet")
            {
                Console.WriteLine("Ievadiet 1 lai butu fun ar restitem");
                Console.WriteLine("2 lai butu more fun ar restitem v3");
                Console.WriteLine("3 lai butu extra fun ar restutem v4");
                Console.WriteLine("4 lai butu mega fun ar Zvaigznite vai restite");
                Console.WriteLine("\"iziet\" lai izietu");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Restite();
                        break;
                    case "2":
                        Restite3();
                        break;
                    case "3":
                        Restite4();
                        break;
                    case "4":
                        ZvaigzniteVaiRestite();
                        break;
                    case "iziet":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }


        }

        private void Restite()
        {
            int reizes = Ievade();
            char restite = '#';
            for (int i = 0; i < reizes; i++)
            {
                Console.Write(restite);
            }
            Console.WriteLine();
        }

        private void Restite3()
        {
            int skaitlis = Ievade();

            char[] restites = new char[skaitlis];

            for (int i = 0; i < skaitlis; i++)
            {
                restites[i] = '#';
                Console.Write(restites[i]);
            }
        }

        public void Restite4()
        {
            String[] reste = new string[5] { "# ##### # ##### # ##### # #####", "## #### ## #### ## #### ## ####", "### ### ### ### ### ### ### ###", "#### ## #### ## #### ## #### ##", "##### # ##### # ##### # ##### #" };

            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(reste[i]);
            }
        }

        public void BrainFuck()
        {
            int skaitlis = Ievade();

            int fak = 0;
            for (int i = 1; i <= skaitlis; i++)
            {
                fak = fak + i;
            }
            Console.Write("The fakin result is " + fak);
        }

        public void ZvaigzniteVaiRestite()
        {
            String[] vii = new String[20];

            for (int i = 0; i < vii.Length; i++)
            {

                if (i % 2 == 0)
                {
                    vii[i] = "*";
                }
                else
                {
                    vii[i] = "#";
                }                                     
            }

            for (int i = 0; i < vii.Length; i++)
            {
                Console.Write(vii[i] + " ");
            }

        }


        private int Ievade()
        {
            int result;
            try
            {
                Console.WriteLine("Ievadiet skaitli!");
                String virkne = Console.ReadLine();
                result = Convert.ToInt16(virkne);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Surprise Motherf#cker! Ievadita vertiba ir nepareiza, tiek pieskirta vertiba 5");
                Console.WriteLine(ex);
                result = 5;
            }
            return result;
        }
    }
}

