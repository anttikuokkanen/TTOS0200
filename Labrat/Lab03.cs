using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Olio-ohjelmoinnin viikkotehtävät Labra2
//Antti Kuokkanen

namespace Labrat
{
    class Lab03
    {
        public class Kiuas
        {
            //properties
            public bool Virta { get; set; }
            public int Lampotila { get; set; }
            public int Kosteus { get; set; }

            //constructors
            public Kiuas()
            {
                this.Lampotila = Lampotila;
                this.Virta = Virta;
                this.Kosteus = Kosteus;
            }

            //methods
            public void OnkoPaalla()
            {
                if (Virta == true) {
                    Console.WriteLine("Sauna on päällä.");
                    KiuasAjo.TestaaKiuas();
                }
                else if (Virta == false) {
                    Console.WriteLine("Sauna on pois päältä.");
                    KiuasAjo.TestaaKiuas();
                }
            }
            public void AsetaLampo()
            {
                Console.WriteLine("Paljonko laitetaan lämmintä: ");
                Lampotila = int.Parse(Console.ReadLine());
                Console.WriteLine("Lämmintä on nyt " + Lampotila + " C");
                KiuasAjo.TestaaKiuas();
            }
            public void AsetaKosteus()
            {
                Console.WriteLine("Paljonko laitetaan kosteutta: ");
                Kosteus = int.Parse(Console.ReadLine());
                Console.WriteLine("Kosteutta on nyt " + Kosteus + " %");
                KiuasAjo.TestaaKiuas();
            }




        }
        public class KiuasAjo
        {
            public static void TestaaKiuas()
            {

                Kiuas Harvia = new Kiuas();
                int valinta = 5;
                Console.WriteLine("Valitse haluamasi toiminto:");
                Console.WriteLine("Sauna päälle valitsemalla 1 tai pois päältä valitsemalla 2:");
                Console.WriteLine("Aseta saunan lämpötila valitsemalla 3");
                Console.WriteLine("Aseta saunan kosteus valitsemalla 4");
                Console.WriteLine("Poistu saunasta valitsemalla 0");
                valinta = int.Parse(Console.ReadLine());
                if (valinta == 1)
                {
                    Harvia.Virta = true;
                    Harvia.OnkoPaalla();

                }
                else if (valinta == 2)
                {
                    Harvia.Virta = false;
                    Harvia.OnkoPaalla();

                }
                else if (valinta == 3)
                {
                    Harvia.AsetaLampo();
                }
                else if (valinta == 4)
                {
                    Harvia.AsetaKosteus();
                }
                else if (valinta == 0)
                {
                    Console.WriteLine("Siihen loppui saunominen tällä erää");
                }
            }
        }

    }
}


