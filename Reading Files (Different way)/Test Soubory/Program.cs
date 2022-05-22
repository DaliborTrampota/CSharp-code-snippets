/*using System;
using System.Collections.Generic;
using System.IO;

namespace Test_Soubory
{
    class Program
    {

        static void Main(string[] args)
        {
            string soubor = "soubor.txt";
            List<Osoba> osoby = NacistSoubor(soubor);

            short pocetOsob;
            bool chyba;
            do
            {
                Console.WriteLine("Zadej kolik chceš zadat osob --> ");
                chyba = short.TryParse(Console.ReadLine(), out pocetOsob);
            } while (!chyba);

            for(short i = 0; i < pocetOsob; i++)
            {
                Osoba clovek = VytvorOsobu();
                osoby.Add(clovek);
                Console.Clear();
                Console.WriteLine("Osoba přidána");
            }

            UlozOsoby(osoby, soubor);
            Console.WriteLine("Osoby byly uloženy. Pro ukončení programu stiskněte libovolnou klávesu.");
            Console.ReadKey();
        }

        static List<Osoba> NacistSoubor(string soubor)
        {
            List<Osoba> osoby = new List<Osoba>();
            using (StreamReader R = new StreamReader(soubor))
            {
                string radek;
                while ((radek = R.ReadLine()) != null)
                {
                    string[] pole = radek.Split(';');
                    osoby.Add(new Osoba(pole[0], short.Parse(pole[1])));
                }
            }
            return osoby;
        }

        static Osoba VytvorOsobu()
        {
            Console.WriteLine("Zadej jméno --> ");
            string jmeno = Console.ReadLine();

            short vek;
            bool chyba;
            do
            {
                Console.WriteLine("Zadej věk --> ");
                chyba = short.TryParse(Console.ReadLine(), out vek);
            } while (!chyba);

            return new Osoba(jmeno, vek);
        }

        static void UlozOsoby(List<Osoba> osoby, string soubor)
        {
            using(StreamWriter W = new StreamWriter(soubor, false))
            {
                foreach (Osoba os in osoby)
                {
                    W.WriteLine("{0};{1}", os.Jmeno, os.Vek);
                }
            }
        }
    }

    class Osoba
    {
        public string Jmeno { get; private set; }
        public short Vek { get; private set; }
        public Osoba(string jmeno, short vek)
        {
            Jmeno = jmeno;
            Vek = vek;
        }
    }
}*/
