using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Matematika
    {/*
        public void Saskaitīt()
        {
            int a;
            int b;

            a = SkaitlaIevade();
            b = SkaitlaIevade();
            int summa = a + b;

            Console.WriteLine(summa);
        }

        public void Atnemsana()
        {
            int a;
            int b;

            a = SkaitlaIevade();
            b = SkaitlaIevade();
            int summa = a - b;

            Console.WriteLine(summa);
        }

        public void Apvienota()
        {
            int a;
            int b;

            a = SkaitlaIevade();
            b = SkaitlaIevade();

            Console.WriteLine("Ievadiet 1, lai saskaititu vai 2, lai atnemtu");
            String izvele = Console.ReadLine();

            if (izvele == "1")
            {
                Console.WriteLine(a + b);
            }
            else if (izvele == "2")
            {
                Console.WriteLine(a - b);
            }
            else
            {
                Console.WriteLine("Ievade nav pareiza");
            }

        }*/

        private int SkaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            return jaunaisSkaitlis;
        }

        /*public void Teikums()
        {
            
            String teikums = "";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet Vardu: ");
                String pasreizejais = Console.ReadLine();
                teikums = teikums + pasreizejais + " ";
                
            }
            Console.WriteLine(teikums);
        }*/

        public void Kapinasana()
        {
            int pakape = SkaitlaIevade();
            int skaitlis = SkaitlaIevade();
            int result = 1;
            for (int i = 0; i < pakape; i++)
            {
                result = result * skaitlis;
            }

            Console.WriteLine(result);


        }
    }
}
