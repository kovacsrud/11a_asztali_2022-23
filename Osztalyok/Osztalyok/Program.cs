﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Példányosítás
            Auto auto1 = new Auto("KLG-001","Skoda","Octavia",2012);
            Auto auto2 = new Auto("KLX-451", "Ford", "Mondeo", 2022);
            JobbAuto jobbauto1=null;

            try
            {
                jobbauto1 = new JobbAuto("DER-124", "Seat", "Ibiza", 2029);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            

            JobbAuto jobbauto2 = new JobbAuto
            {
                Rendszam = "ZTR-556",
                Marka = "Opel",
                Tipus = "Astra",
                GyartasiEv = 2008
            };

            //auto1.rendszam = "KLG-001";
            //auto1.marka = "Skoda";
            //auto1.tipus = "Octavia";
            //auto1.gyartasiev = 2012;

            //Console.WriteLine(auto1.rendszam);

            auto1.setRendszam("KLG-101");

            Console.WriteLine(auto1.getRendszam());
            Console.WriteLine(auto2.getRendszam());

            if (jobbauto1!=null)
            {
                Console.WriteLine(jobbauto1.Marka);
            }
            

            Console.ReadKey();
        }
    }
}
