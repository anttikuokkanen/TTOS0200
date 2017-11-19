using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab11._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            int draws;
            Random rng = new Random();
            if (int.TryParse(txtDraws.Text, out draws))
            {
                if (cmbGame.Text == "Lotto")
                {
                    int raw = 0;
                    string rivit = null;
                    for (int y = 0; y < draws; y++)
                    {
                        List<int> lotterynumbers = new List<int>();
                        int number;
                        for (int i = 0; i < 7; i++)
                        {
                            do
                            {
                                number = rng.Next(1, 41);
                            } while (lotterynumbers.Contains(number));
                            lotterynumbers.Add(number);
                        }
                        raw++;
                        rivit += "Raw " + raw + ": " + String.Join(", ", lotterynumbers.ToArray()) + "\n";
                    }
                   
                    txbNumbers.Text = rivit;
                }

                else if (cmbGame.Text == "Viking Lotto")
                {
                    int raw = 0;
                    string rivit = null;
                    for (int y = 0; y < draws; y++)
                    {
                        List<int> lotterynumbers = new List<int>();
                        int number;
                        for (int i = 0; i < 6; i++)
                        {
                            do
                            {
                                number = rng.Next(1, 49);
                            } while (lotterynumbers.Contains(number));
                            lotterynumbers.Add(number);
                        }
                        raw++;
                        rivit += "Raw " + raw + ": " + String.Join(", ", lotterynumbers.ToArray()) + "\n";
                    }

                    txbNumbers.Text = rivit;

                }

                else if (cmbGame.Text == "Eurojackpot")
                {
                    int raw = 0;
                    string rivit = null;
                    for (int y = 0; y < draws; y++)
                    {
                        List<int> lotterynumbers = new List<int>();
                        int number;
                        for (int i = 0; i < 5; i++)
                        {
                            do
                            {
                                number = rng.Next(1, 51);
                            } while (lotterynumbers.Contains(number));
                            lotterynumbers.Add(number);
                        }
                        for (int i = 0; i < 2; i++)
                        {
                            do
                            {
                                number = rng.Next(1, 11);
                            } while (lotterynumbers.Contains(number));
                            lotterynumbers.Add(number);
                        }
                        raw++;
                        rivit += "Raw " + raw + ": " + String.Join(", ", lotterynumbers.ToArray()) + "\n";
                    }

                    txbNumbers.Text = rivit;
                }

            }
            else
            {
                txbNumbers.Text = "";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbNumbers.Text = "";
        }
    }
}
