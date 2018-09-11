using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    class Piemeri
    {
        /*public void Interfeiss()
        {
            int mainigais = 5;
            int[] pirmaisMasivs =  new int[mainigais];

            pirmaisMasivs[0] = 1;
            pirmaisMasivs[1] = 7;
            pirmaisMasivs[2] = 8;
            pirmaisMasivs[3] = 9;
            pirmaisMasivs[4] = 3;

            for (int i = 0; i < pirmaisMasivs.Length; i++)
            {
                Console.WriteLine(pirmaisMasivs[i]);
            }

        }*/

        public void Interfeiss()
        {
            //PirmaisPiemers();
            //ZvaigznesArray();
            //ZvaigznesDivi();
            DiviDe();
        }


        private void PirmaisPiemers()
        {
            int mainigais = 5;
            int[] pirmaisMasivs = new int[mainigais];





            for (int i = 0; i < pirmaisMasivs.Length; i++)
            {
                Console.WriteLine("Ievadiet masiva vertibu");
                String vertiba = Console.ReadLine();

                int masivaVertiba = Convert.ToInt16(vertiba);
                pirmaisMasivs[i] = masivaVertiba;
            }

            /*for (int i = 0; i < mainigais; i++)
            {
                Console.WriteLine(pirmaisMasivs[i]);
            }*/
        }


        private void ZvaigznesArray()
        {
            String[] zvaigznes = new string[4] { "*", "**", "***", "****" };

            for(int i = 0; i < zvaigznes.Length; i++)
            {
                Console.WriteLine(zvaigznes[i]);
            }
        }

        private void ZvaigznesDivi()
        {
            String[] zvaigznes = new string[4] { "*", "*", "*", "*" };

            for (int i = 0; i < zvaigznes.Length; i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write(zvaigznes[j]);
                }
                Console.WriteLine();
                
            }

        }


        private void DiviDe()
        {
            int[,] otraisMasivs = new int[2,2];
            otraisMasivs[0, 0] = 5;
            otraisMasivs[0, 1] = 1;
            otraisMasivs[1, 0] = 6;
            otraisMasivs[1, 1] = 9;

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(otraisMasivs[i, j]);
                }
                Console.WriteLine();
            }
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
