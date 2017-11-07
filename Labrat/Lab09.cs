using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab09
    {
        public class Tehtava1
        {
            public class Dice
            {
                public int Tulos { get; set; }
                static Random rng = new Random();

                public int Heita()
                {
                    int dice = rng.Next(1, 7);
                    Tulos = dice;
                    return Tulos;
                }
            }
            public static void TestaaNoppa()
            {
                try
                {
                    List<int> lista = new List<int>();
                    Dice noppa = new Dice();
                    Console.WriteLine("Ensimmäinen heitto oli: " + noppa.Heita());
                    Console.WriteLine("Montako kertaa haluat heittää?");
                    int input = int.Parse(Console.ReadLine());
                    for (int i = 0; i < input; i++)
                    {
                        lista.Add(noppa.Heita());
                    }
                    Console.WriteLine("Noppaa heitettiin {0} kertaa, keskiarvo on {1}", input, lista.Average());

                    lista.Sort();

                    var q = lista.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() });

                    foreach (var x in q)
                    {
                        Console.WriteLine("Luku " + x.Value + " esiintyy " + x.Count + " kertaa");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public class Tehtava2
        {
            public class Tuote
            {
                public string Nimi { get; set; }
                public double Hinta { get; set; }

                public Tuote()
                {
                }
                public Tuote(string nimi, double hinta)
                {
                    Nimi = nimi;
                    Hinta = hinta;
                }
                public override string ToString()
                {
                    return string.Format("Tuote : {0} {1} e", Nimi, Hinta);
                }
            }
            public static void TestaaOstokset()
            {
                try
                {
                    List<Tuote> ostoskori = new List<Tuote>();
                    int valinta;
                    string nimi;
                    double hinta;
                    Console.WriteLine("Lisätään tuotteita.");
                    do
                    {
                        Console.WriteLine("Nimi: ");
                        nimi = Console.ReadLine();
                        Console.WriteLine("Hinta: ");
                        hinta = double.Parse(Console.ReadLine());
                        ostoskori.Add(new Tuote { Nimi = nimi, Hinta = hinta });
                        Console.WriteLine("Vieläkö lisätään? 0=ei, 1=kyllä");
                        valinta = int.Parse(Console.ReadLine());
                    } while (valinta == 1);
                    Console.WriteLine("Ostoskorin sisältö: ");
                    foreach (var item in ostoskori)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
