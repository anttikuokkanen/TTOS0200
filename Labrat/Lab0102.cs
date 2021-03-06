﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Olio-ohjelmoinnin viikkotehtävät Labra1
//Antti Kuokkanen

namespace Labrat
{
    class Lab0102
    {
        public static void Tehtava1 ()
        {
            // Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 
            int luku;
            Console.Write("Anna luku yhdestä kolmeen > ");
            luku = int.Parse(Console.ReadLine());
            if (luku == 1) {
                Console.WriteLine("Annoit luvun yksi");
            }
            else if (luku == 2) {
                Console.WriteLine("Annoit luvun kaksi");
            }
            else if (luku == 3) {
                Console.WriteLine("Annoit luvun kolme");
            }
            else {
                Console.WriteLine("Joku muu luku");
            }

        }

        public static void Tehtava2 ()
        {
            // Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron)
            int pisteet;
            Console.Write("Anna oppilaan saamat pisteet > ");
            pisteet = int.Parse(Console.ReadLine());
            if (pisteet >=0 && pisteet <=1 ) {
                Console.WriteLine("Tulos on 0");
            }
            else if (pisteet <= 3) {
                Console.WriteLine("Tulos on 1");
            }
            else if (pisteet <= 5) {
                Console.WriteLine("Tulos on 2");
            }
            else if (pisteet <= 7) {
                Console.WriteLine("Tulos on 3");
            }
            else if (pisteet <= 9) {
                Console.WriteLine("Tulos on 4");
            }
            else if (pisteet <= 12) {
                Console.WriteLine("Tulos on 5");
            }


        }
        
        
        public static void Tehtava3 ()
        {
            // Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
            int luku1;
            int luku2;
            int luku3;
            Console.Write("Anna ensimmäinen luku > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku > ");
            luku3 = int.Parse(Console.ReadLine());
            double summa = luku1 + luku2 + luku3;
            Console.WriteLine("Lukujen summa: " + summa);
            double keskiarvo = summa/3;
            Console.WriteLine("Lukujen keskiarvo: " + keskiarvo);


        }
        
        public static void Tehtava4 ()
        {
            // Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
            int age;
            Console.Write("Kerro ikäsi > ");
            age = int.Parse(Console.ReadLine());
            if (age <18 ) {
                Console.WriteLine("Alaikäinen");
            }
            else if (age <= 65) {
                Console.WriteLine("Aikuinen");
            }
            else {
                Console.WriteLine("Seniori");
            }
        }


        
        public static void Tehtava5 ()
        {
            // Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä. 
            int seconds;
            int hours;
            int minutes;
            Console.Write("Anna sekunnit > ");
            seconds = int.Parse(Console.ReadLine());
            hours = seconds/3600;
            minutes = (seconds - (hours*3600))/60;
            seconds = seconds - hours*3600 - minutes*60;
            Console.WriteLine("Kirjoittamasi aika voidaan ilmaista muodossa: " + hours + " tunti " + minutes + " minuutti " + seconds + " sekunti ");

        }


        public static void Tehtava6 ()
        {
            // Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän. 
            double distance;
            double gasoline;
            double price;
            Console.Write("Anna matka > ");
            distance = int.Parse(Console.ReadLine());
            gasoline = distance/100 * 7.02;
            price = gasoline * 1.595;
            Console.WriteLine("Bensaa kuluu " + gasoline + " litraa, " + " kustannus " + price + " euroa");
        }

        
        public static void Tehtava7 ()
        {
            // Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä. 
            int year;
            Console.Write("Anna vuosiluku > ");
            year = int.Parse(Console.ReadLine());
            if (year % 400 == 0) {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else if (year % 4 == 0 && year % 100 != 0) {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }

        }

        
        public static void Tehtava8 ()
        {
            // Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
            int luku1;
            int luku2;
            int luku3;
            Console.Write("Anna ensimmäinen luku > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku > ");
            luku3 = int.Parse(Console.ReadLine());
            if (luku1 >= luku2 && luku1 >= luku3) {
                Console.WriteLine("Suurin luku näistä: " + luku1);
            }
            else if (luku2 >= luku1 && luku2 >= luku3) {
                Console.WriteLine("Suurin luku näistä: " + luku2);
            }
            else if (luku3 >= luku1 && luku3 >= luku2) {
                Console.WriteLine("Suurin luku näistä: " + luku3);
            }

        }

        

        public static void Tehtava9 ()
        {
            // Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa. 
            int number;
            int sum=0;
            do {
                Console.Write("Anna luku > ");
                number = int.Parse(Console.ReadLine());
                sum = number + sum;
            } while (number != 0);
            Console.WriteLine("Lukujen summa: " + sum);


        }
        

        public static void Tehtava10 ()
        {
            // Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.  
            int[] numbers = {1,2,33,44,55,68,77,96,100};

            for (int i=0;i<numbers.Length;i++) {
                //Console.WriteLine(numbers[i]);

                if (numbers[i] % 2 == 0) {
                    Console.Write(numbers[i]);
                    Console.WriteLine(" HEP");
                }
                else {
                    Console.WriteLine(numbers[i]);
                }
            }
        }


        
        public static void Tehtava11 ()
        {
            // Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion. Käyttäjä antaa syötteenä tähtirivien lukumäärän. 
            int number;
            Console.Write("Anna luku > ");
            number = int.Parse(Console.ReadLine());
            for (int row = 1; row <= number; ++row) {
                
                for (int col = 1; col <= row; ++col) {
                Console.Write("*");
                }
 
            Console.WriteLine();
            }

        }


        
        public static void Tehtava12 ()
        {
            // Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä. 
            int[] numbers = new int[5];
            for (int i=0;i<5;i++) {
                Console.Write("Anna luku > ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Luvut ovat " + numbers[4] + "," + numbers[3] + "," + numbers[2] + "," + numbers[1] + "," + numbers[0]);

        }

        
        public static void Tehtava13 ()
        {
            // Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.  
            int[] numbers = new int[5];
            int sum;
            for (int i=0;i<5;i++) {
                Console.Write("Anna luku > ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            sum = numbers[4] + numbers[3] + numbers[2] + numbers[1] + numbers[0] - numbers.Max() - numbers.Min();
            Console.WriteLine("Kokonaispisteet ovat " + sum);
        }

        /*
        public static void Tehtava14 ()
        {
            // Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 


        }

        public static void Tehtava15 ()
        {
            // Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 


        }

        public static void Tehtava16 ()
        {
            // Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 


        }

        public static void Tehtava17 ()
        {
            // Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 


        }

        public static void Tehtava18 ()
        {
            // Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 


        }

        public static void Tehtava19 ()
        {
            // Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 


        }

        public static void Tehtava20 ()
        {
            // Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 


        }
        
        */

    }
}


