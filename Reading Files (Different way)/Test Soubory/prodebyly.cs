using System;
using System.Collections.Generic;
using System.IO;

namespace Test_Soubory
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Osoba> osoby = new List<Osoba>();
            string soubor = "soubor.txt";
            Console.WriteLine("Zadej pocet osob --> ");
            int pocetOsob = int.Parse(Console.ReadLine());

            for (int i = 0; i < pocetOsob; i++)
            {
                Console.WriteLine("Zadej jméno --> ");
                string jmeno = Console.ReadLine();
                Console.WriteLine("Zadej vek --> ");
                int vek = int.Parse(Console.ReadLine());
                osoby.Add(new Osoba(jmeno, vek));
            }

            using (StreamReader R = new StreamReader(soubor))
            {
                string radek;
                while ((radek = R.ReadLine()) != null)
                {
                    string[] pole = radek.Split(';');
                    osoby.Add(new Osoba(pole[0], short.Parse(pole[1])));
                }
            }

            using (StreamWriter W = new StreamWriter(soubor, false))
            {
                foreach (Osoba os in osoby)
                {
                    W.WriteLine("{0};{1}", os.Jmeno, os.Vek);
                }
            }
            Console.ReadKey();
        }

    }

    class Osoba
    {
        public string Jmeno { get; private set; }
        public int Vek { get; private set; }
        public Osoba(string jmeno, int vek)
        {
            Jmeno = jmeno;
            Vek = vek;
        }
    }
}
