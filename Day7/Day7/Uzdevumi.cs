using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Uzdevumi
    {
        public void Izvelne()
        {
            //TODO Pievienot funkcijas
            Viendimensiju();
        }



        private void Viendimensiju()
        {
            int mainigais = Parveidosana();


            String[] pirmaisMasivs;

            if (mainigais >= 1 && mainigais < 9)
            {
                pirmaisMasivs = new String[mainigais];
                for (int i = 0; i < pirmaisMasivs.Length; i++)
                {
                    /*Console.WriteLine("Ievadiet masiva vertibu");
                    String vertiba = Console.ReadLine();*/
                    Console.WriteLine("Ievadiet masiva vertibu");
                    pirmaisMasivs[i] = Console.ReadLine();
                    if (pirmaisMasivs[i].Length > 6)
                    {
                        pirmaisMasivs[i] = "!ERROR!";
                    }
                }

                for (int i = 0; i < pirmaisMasivs.Length; i++)
                {
                    Console.WriteLine(pirmaisMasivs[i]);
                }
            }
            else
            {
                Console.WriteLine("Nepareiza vertiba");
                Viendimensiju();
            }
        }

        //Cilveks ievada masiva garumu
        //parbaudam ievadi, nedrikst but mazaks/vienads par 0
        //un lielaks par 9
        //ja cilveks nav ievadijis pareizi, atkartoti liekam ievadit pareizi
        //tad uztaisam tada garuma masivu
        //masivam jabut String tipa
        //Cilvekam jaievada masiva vertibas
        //ja ievadita string garums ir lielaks par 6, tad ierakstam masiva nevis to vertibu, bet "!ERROR!"
        //talak masivu izvadam

        private void Divdimensiju()
        {

        }

        private int Parveidosana()
        {
            int result = 0;
            try
            {
                Console.WriteLine("Ievadiet masiva garumu!");
                String virkne = Console.ReadLine();
                result = Convert.ToInt16(virkne);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nepareiza ievade, masivam pieskirts garums 5");
                Console.WriteLine(ex.Message);
                result = 5;
            }

            return result;
        }
    }
}
