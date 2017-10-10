using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab06
    {
        public class Tehtava1
        {
            class Rengas
            {
                public string Merkki { get; set; }
                public string Malli { get; set; }
                public string Rengaskoko { get; set; }

                public Rengas()
                {
                }

                public Rengas(string merkki, string malli, string rengaskoko)
                {
                    Merkki = merkki;
                    Malli = malli;
                    Rengaskoko = rengaskoko;
                }
                public override string ToString()
                {
                    return "Merkki: " + Merkki + " Malli: " + Malli + " Rengaskoko: " + Rengaskoko;
                }
            }

            class Kulkuneuvo
            {
                public string Merkki { get; set; }
                public string Malli { get; set; }
                public List<Rengas> Renkaat;
                public Kulkuneuvo()
                {
                    Renkaat = new List<Rengas>();
                }

                public override string ToString()
                {
                    string retval = "Merkki: " + Merkki +  " Malli: " + Malli + "\n";
                    foreach (Rengas rengas in Renkaat)
                    {
                        retval += rengas.ToString() + "\n";
                    }
                    return retval;

                }
            }

            public static void TestClasses()
            {
                Kulkuneuvo auto = new Kulkuneuvo();
                auto.Merkki = "Porsche";
                auto.Malli = "911";
                auto.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R16"));
                auto.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R16"));
                auto.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R16"));
                auto.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R16"));
                Console.WriteLine(auto.ToString());

                Kulkuneuvo mp = new Kulkuneuvo();
                mp.Merkki = "Ducati";
                mp.Malli = "Diavel";
                mp.Renkaat.Add(new Rengas("MIC", "Pilot", "160R17"));
                mp.Renkaat.Add(new Rengas("MIC", "Pilot", "160R17"));
                Console.WriteLine(mp.ToString());

            }
        }

        public class Jaakaappi
        {
            class Elintarvike
            {
                public string Nimi { get; set; }
                public string Parastaennen { get; set; }
                public Elintarvike()
                {
                }

                public Elintarvike(string nimi, string parastaennen)
                {
                    Nimi = nimi;
                    Parastaennen = parastaennen;
                }


                public override string ToString()
                {
                    return "Nimi: " + Nimi + " Parasta ennen: " + Parastaennen;
                }
            }



            class Juomat : Elintarvike
            {
                public string Juomalaatu { get; set; }

                public Juomat()
                {
                }

                public Juomat(string juomalaatu, string nimi, string parastaennen)
                    :base (nimi, parastaennen)
                {
                    Juomalaatu = juomalaatu;
                }
                public override string ToString()
                {
                    return base.ToString() + " Juoman tyyppi: " + Juomalaatu;
                }

            }

            class Lihatuotteet : Elintarvike
            {
                public string Lihatyyppi { get; set; }

                public Lihatuotteet()
                {
                }
                public Lihatuotteet(string lihatyyppi, string nimi, string parastaennen)
                    :base (nimi, parastaennen)
                {
                    Lihatyyppi = lihatyyppi;
                }
                public override string ToString()
                {
                    return base.ToString() + " Lihan tyyppi: " + Lihatyyppi;
                }

            }

            public static void TestaaJaakaappi()
            {
                Juomat virvoke = new Juomat();
                virvoke.Nimi = "Jaffa";
                virvoke.Parastaennen = "21.12.2019";
                virvoke.Juomalaatu = "Virvoitusjuoma";
                Console.WriteLine(virvoke.ToString());

                Lihatuotteet liha = new Lihatuotteet();
                liha.Nimi = "Jauheliha";
                liha.Parastaennen = "15.10.2017";
                liha.Lihatyyppi = "Kana";
                Console.WriteLine(liha.ToString());
            }
        }

        public class Tehtava3
        {
            public class Pelaaja
            {
                public string Etunimi { get; set; }
                public string Sukunimi { get; set; }
                public string Pelipaikka { get; set; }
                public string Katisyys { get; set; }

                public Pelaaja(string etunimi, string sukunimi, string pelipaikka, string katisyys)
                {
                    Etunimi = etunimi;
                    Sukunimi = sukunimi;
                    Pelipaikka = pelipaikka;
                    Katisyys = katisyys;
                }
                public Pelaaja()
                {
                }
                public override string ToString()
                {
                    return Etunimi + " " + Sukunimi + " " + Pelipaikka + " " + Katisyys;
                }
            }
            public class Seura
            {
                public string Nimi { get; set; }
                public string Kaupunki { get; set; }
                public List<Pelaaja> Pelaajat;

                public Seura()
                {
                    Pelaajat = new List<Pelaaja>();
                }
                public Seura(string nimi, string kaupunki)
                {
                    Nimi = nimi;
                    Kaupunki = kaupunki;
                }
                public override string ToString()
                {
                    string retval = "Seura: " + Nimi + " Kotikaupunki: " + Kaupunki + "\n";
                    foreach (Pelaaja pelaaja in Pelaajat)
                    {
                        retval += pelaaja.ToString() + "\n";
                    }
                    return retval;
                }
            }
            public static void TestaaSeura()
            {
                Seura saipa = new Seura();
                saipa.Nimi = "SaiPa";
                saipa.Kaupunki = "Lappeenranta";
                saipa.Pelaajat.Add(new Pelaaja("Jussi", "Markkanen", "MV", "L"));
                saipa.Pelaajat.Add(new Pelaaja("Kasperi", "Torikka", "VP", "L"));
                saipa.Pelaajat.Add(new Pelaaja("Lasse", "Lappalainen", "OP", "L"));
                saipa.Pelaajat.Add(new Pelaaja("Ville", "Koho", "KH", "L"));
                saipa.Pelaajat.Add(new Pelaaja("Joni", "Nikko", "VL", "L"));
                saipa.Pelaajat.Add(new Pelaaja("Valtteri", "Virkkunen", "VL", "L"));

                Seura jyp = new Seura();
                jyp.Nimi = "JYP";
                jyp.Kaupunki = "Jyväskylä";
                jyp.Pelaajat.Add(new Pelaaja("Eetu", "Laurikainen", "MV", "L"));
                jyp.Pelaajat.Add(new Pelaaja("Mikko", "Kalteva", "VP", "L"));
                jyp.Pelaajat.Add(new Pelaaja("Juuso", "Vainio", "OP", "R"));
                jyp.Pelaajat.Add(new Pelaaja("Joonas", "Nättinen", "KH", "R"));
                jyp.Pelaajat.Add(new Pelaaja("Juuso", "Puustinen", "OL", "R"));
                jyp.Pelaajat.Add(new Pelaaja("Jani", "Tuppurainen", "VL", "L"));

                Console.WriteLine("Kumman seuran pelaajat haluat tulostaa? (1: JYP, 2: SaiPa)");
                int valinta = int.Parse(Console.ReadLine());
                if (valinta == 1)
                {
                    Console.WriteLine(jyp.ToString() + "jne jne \n");
                }
                else if (valinta == 2)
                {
                    Console.WriteLine(saipa.ToString() + "jne jne \n");
                }
                else
                {
                    Console.WriteLine("Väärä komento");
                }
            }
        }

        public class Tehtava4
        {
            abstract class Nisakas
            {
                public int Ika { get; set; }

                public abstract void Liiku();
            }
            class Ihminen : Nisakas
            {
                public string Nimi { get; set; }
                public int Pituus { get; set; }
                public int Paino { get; set; }

                public Ihminen(string nimi, int pituus, int paino)
                {
                    Nimi = nimi;
                    Pituus = pituus;
                    Paino = paino;
                }
                public Ihminen()
                {
                }
                public int Kasva()
                {
                    Ika = Ika + 1;
                    return Ika;
                }

                public override void Liiku()
                {
                    Console.WriteLine("Liikun");
                }
            }
            class Vauva : Ihminen
            {
                public string Vaippa { get; set; }

                public Vauva(string nimi, int pituus, int paino)
                    : base(nimi, pituus, paino)
                {

                }
                public Vauva()
                {

                }
                public override void Liiku()
                {
                    Console.WriteLine("Konttaa");
                }
            }
            class Aikuinen : Ihminen
            {
                public string Auto { get; set; }

                public Aikuinen(string nimi, int pituus, int paino)
                    : base(nimi, pituus, paino)
                {

                }

                public override void Liiku()
                {
                    Console.WriteLine("Kävelee");
                }
            }
            public static void TestClasses()
            {
                Ihminen ihminen = new Ihminen("Helmu-Ilari", 170, 83);
                ihminen.Ika = 42;
                Console.WriteLine("Uusi ihminen luotu, nimi:" + ihminen.Nimi + " ikä:" + ihminen.Ika + " pituus:" + ihminen.Pituus + " paino:" + ihminen.Paino);
                ihminen.Liiku();
                ihminen.Kasva();
                Console.WriteLine("Ikäsi on nyt: " + ihminen.Ika + "\n");

                Vauva vauva = new Vauva("Taavi-Vauva", 30, 7);
                vauva.Vaippa = "Löytyy";
                Console.WriteLine("Uusi vauva luotu, nimi:" + vauva.Nimi + " Ikä:" + vauva.Ika + " Pituus:" + vauva.Pituus + " Paino:" + vauva.Paino + " Vaipat:" + vauva.Vaippa);
                vauva.Liiku();
                vauva.Kasva();
                Console.WriteLine("Ikäsi on: " + vauva.Ika + "\n");

                Aikuinen aikuinen = new Aikuinen("Markku", 199, 97);
                aikuinen.Auto = "Datsun 100";
                aikuinen.Ika = 25;
                Console.WriteLine("Uusi aikuinen luotu, nimi:" + aikuinen.Nimi + " Ikä:" + aikuinen.Ika + " Pituus:" + aikuinen.Pituus + " Paino:" + aikuinen.Paino + " Auto:" + aikuinen.Auto);
                aikuinen.Liiku();
                aikuinen.Kasva();
                Console.WriteLine("Ikäsi on nyt: " + aikuinen.Ika);

            }
        }
    }
}
