using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class PirmaisPiemers
    {

        public void DarbibaArMasivu()
        {

            String[] masivs = new String[4];

            String ievade = "";

            while (ievade != "iziet")
            {
                for (int i = 0; i < masivs.Length; i++)
                {
                    Console.WriteLine("Ievadiet vertibu");
                    ievade = Console.ReadLine();
                    if (ievade == "iziet")
                    {
                        break;
                    }
                    masivs[i] = ievade;
                    //Console.WriteLine(masivs[0] + masivs[1] + masivs[2] + masivs[3]);
                    for (int j = 0; j < masivs.Length; j++)
                    {
                        Console.Write(masivs[j]);
                    }
                    Console.WriteLine();
                }

            }

        }

        public void Stripes()
        {
            String[] array = new string[4];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = "-";
                Console.Write(array[i]);
            }
        }
    }
}
