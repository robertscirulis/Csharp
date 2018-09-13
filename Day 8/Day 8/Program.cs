using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            PirmaisPiemers pir = new PirmaisPiemers();

            String izvele = "";

            while (izvele != "iziet")
            {
                Console.WriteLine("Nospiediet 1, lai ievaditu masiva vertibas");
                izvele = Console.ReadLine();
                switch (izvele)
                {
                    case "1":
                        pir.DarbibaArMasivu();
                        break;
                    case "2":
                        pir.Stripes();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
