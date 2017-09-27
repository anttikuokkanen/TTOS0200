using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab03
    {
        public class Tehtava1
        {
            public static bool OnkoLuku(string syote)
            {
                double number;
                Console.Write("Syötä luku: ");
                syote = Console.ReadLine();
                bool result = double.TryParse(syote, out number);
                Console.Write("Syöte " + syote + " on luku: ");
                return result;
                
            }
            public static bool OnkoPvm(string syote)
            {
                var dateFormats = new[] { "dd.MM.yyyy", "dd.MM.yy" };
                Console.Write("Anna päivämäärä (pp.kk.vvvv tai pp.kk.vv): ");
                syote = Console.ReadLine();
                DateTime scheduleDate;
                bool result = DateTime.TryParseExact(syote, dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out scheduleDate);
                Console.Write("Syöte " + syote + " on päivämäärä oikeassa muodossa: ");
                return result;
            }

            public class TestiPeti
            {
                public static void Testaus()
                {
                    while (true)
                    {
                        Console.WriteLine(OnkoLuku(""));
                        Console.WriteLine(" ");
                        Console.WriteLine(OnkoPvm(""));
                        Console.WriteLine(" ");
                    }
                }
                
            }
        }
        public class Hissi
        {
            public int TamaKerros { get; set; }

            public Hissi()
            {
                this.TamaKerros = TamaKerros;
                this.UusiKerros = UusiKerros;
            }

            private int uusikerros=1;
            public int UusiKerros
            {
                get
                {
                    return uusikerros;
                }
                set
                {
                    if (value > 0 && value < 6)
                    {
                        uusikerros = value;
                    }
                    else if (value < 1)
                    {
                        Console.WriteLine("Liian pieni kerros!");
                    }
                    else if (value > 5)
                    {
                        Console.WriteLine("Liian suuri kerros!");
                    }
                }
            }

            public int AsetaKerros()
            {
                Console.Write("Anna uusi kerros (1-5) > ");
                UusiKerros = int.Parse(Console.ReadLine());
                return UusiKerros;
            }

            public void TulostaKerros()
            {
                TamaKerros = UusiKerros;
                Console.WriteLine("Hissi on nyt kerroksessa " + TamaKerros);
            }

            public static void TestiHissi()
            {
                Hissi dynamo = new Hissi();
                while (true)
                {
                    dynamo.TulostaKerros();
                    dynamo.AsetaKerros();
                }
            }
        }

        public class Vahvistin
        {
            public int VolumeNyt { get; set; }
            public Vahvistin()
            {
                this.VolumeNyt = VolumeNyt;
                this.VolumeUusi = VolumeUusi;
            }

            private int volumeuusi;
            public int VolumeUusi
            {
                get
                {
                    return volumeuusi;
                }
                set
                {
                    if (value >= 0 && value <= 100)
                    {
                        volumeuusi = value;
                    }
                    else if (value < 0)
                    {
                        Console.WriteLine("Liian pieni äänenvoimakkuus! Asetetaan minimiin: 0");
                        volumeuusi = 0;
                    }
                    else if (value > 100)
                    {
                        Console.WriteLine("Liian suuri äänenvoimakkuus! Asetetaan maksimiin: 100");
                        volumeuusi = 100;
                    }
                }
            }

            public int AsetaVolume()
            {
                Console.Write("Anna uusi äänenvoimakkuus (0-100) > ");
                VolumeUusi = int.Parse(Console.ReadLine());
                return VolumeUusi;
            }

            public void TulostaVolume()
            {
                VolumeNyt = VolumeUusi;
                Console.WriteLine("Äänenvoimakkuus on nyt asetettu: " + VolumeNyt);
            }

            public static void TestiVahvistin()
            {
                Vahvistin onkyo = new Vahvistin();
                while (true)
                {
                    onkyo.AsetaVolume();
                    onkyo.TulostaVolume();
                }
            }


        }

        public class Tehtava4
        {
            class Employee
            {
                public string Name { get; set; }
                public string Profession { get; set; }
                public int Salary { get; set; }

                public Employee()
                {
                }

                public Employee(string name, string profession, int salary)
                {
                    Name = name;
                    Profession = profession;
                    Salary = salary;
                }
                public override string ToString()
                {
                    return "Name: " + Name + " Profession: " + Profession + " Salary: " + Salary;
                }
            }

            class Boss : Employee
            {
                public string Car { get; set; }
                public int Bonus { get; set; }

                public Boss()
                {
                }

                public Boss(string name, string profession, int salary, string car, int bonus)
                    :base(name,profession,salary)
                {
                    Car = car;
                    Bonus = bonus;
                }

                public override string ToString()
                {
                    return base.ToString() + " Car: " + Car + " Bonus: " + Bonus;
                }
            }

            public static void TestClasses()
            {
                Employee employee = new Employee();
                employee.Name = "Taneli";
                employee.Profession = "Muurari";
                employee.Salary = 2600;
                Console.WriteLine(employee.ToString());

                Boss bossi = new Boss();
                bossi.Name = "Frederik";
                bossi.Profession = "Operatiivinen Headmaster";
                bossi.Salary = 4800;
                bossi.Car = "Mersu";
                bossi.Bonus = 600;
                Console.WriteLine(bossi.ToString());

                employee.Salary = 2900;
                Console.WriteLine(employee.ToString());


            }

        }

        /*public class Tehtava5
        {
            class Vehicle
            {
                public string Name { get; set; }
                public string Model { get; set; }
                public int Year { get; set; }
                public string Color { get; set; }

                public Vehicle()
                {
                }

                public Vehicle(string name, string model, int year, string color)
                {
                    Name = name;
                    Model = model;
                    Year = year;
                    Color = color;
                }

                public override string ToString()
                {
                    return 
                }
            }
        }*/
    }
}
