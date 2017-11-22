using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK
{
    public class AMK
    {
        static void Main(string[] args)
        {
        }
    }

    public class Tutkinto: AMK
    {
        public List<Opintojakso> Opintojaksot = new List<Opintojakso>();
        public static List<Opintojakso> HaeOpintojaksot()
        {
            //List<Opintojakso> Opintojaksot = new List<Opintojakso>();
            Tutkinto ttv = new Tutkinto();
            Tutkinto liiketalous = new Tutkinto();
            Tutkinto liikunta = new Tutkinto();
            ttv.Opintojaksot.Add(new Opintojakso("Kyberturvallisuus"));
            ttv.Opintojaksot.Add(new Opintojakso("Kayttojarjestelmat"));
            ttv.Opintojaksot.Add(new Opintojakso("Ohjelmointi"));
            liiketalous.Opintojaksot.Add(new Opintojakso("Sijoittaminen"));
            liiketalous.Opintojaksot.Add(new Opintojakso("Kryptovaluutat"));
            liiketalous.Opintojaksot.Add(new Opintojakso("Liiketoimintosuunnitelma"));
            liikunta.Opintojaksot.Add(new Opintojakso("Extremelajit"));
            liikunta.Opintojaksot.Add(new Opintojakso("Palloilu"));
            liikunta.Opintojaksot.Add(new Opintojakso("Urheilutapahtumat"));
        }

    }

    public class Opintojakso: Tutkinto
    {
        public List<Opiskelija> Opiskelijat { get; set; }
        public List<Opettaja> Opettajat { get; set; }
        public string Nimi { get; set; }
        public Opintojakso(string nimi)
        {
            Nimi = nimi;
        }
    }

    public class Opiskelija
    {
        public string Nimi { get; set; }
        public Opiskelija(string nimi)
        {
            Nimi = nimi;
        }
        public List<Opiskelija> Opiskelijat = new List<Opiskelija>();
        Opiskelija seppo = new Opiskelija();

    }

    public class Opettaja
    {
        public string Nimi { get; set; }
    }


}
