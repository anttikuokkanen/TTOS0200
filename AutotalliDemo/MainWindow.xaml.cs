﻿using System;
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

namespace AutotalliDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot; //muuttuja on käytettävissä kaikissa luokan metodeissa ja tapahtumankäsittelijöissä
        private const string polku = @"D:\K8183\Kuvat\";
        public MainWindow()
        {
            //tänne koodi joka suoritetaan ikkunan avauksen luonnissa
            InitializeComponent();
            NaytaKuva("autotalli.png");
            //pyydetään BL-kerrokselta autot, ja näytetään ne käyttäjälle
            autot = Autotalli.HaeAutot();
            //asetetaan comboboxiin kaikki eri automerkit
            //Vaihtoehto1: Käsin koodaamalla
            /*List<string> merkit = new List<string>();
            merkit.Add("Audi");
            merkit.Add("Saab");
            merkit.Add("UAZ");
            merkit.Add("Volvo");
            cmbAutot.ItemsSource = merkit;*/

            //Vaihtoehto2: Parempi. Kysytään LINQ:lla datasta eri automerkit
            var result = autot.Select(m => m.Merkki).Distinct();
            cmbAutot.ItemsSource = result;
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            dgAutot.ItemsSource = autot;
        }

        private void NaytaKuva(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                //lisätään kuvatiedostojen vakiopolku
                url = polku + url;
                //kuvan näyttö
                BitmapImage pic = new BitmapImage();
                pic.BeginInit();
                pic.UriSource = new Uri(url);
                pic.EndInit();
                imgAuto.Stretch = Stretch.Fill;
                imgAuto.Source = pic;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //huom, olemme itse populoineet DataGridin Auto-olioilla, joten kukin DataGridin jäsen tai alkio on itse asiassa Auto-olio
            object obj = dgAutot.SelectedItem;
            if (obj != null)
            {
                Auto valittu = (Auto)obj;
                NaytaKuva(valittu.URL);
            }
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            //näkyviin pelkästään Audi-merkkiset autot
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }

        private void cmbAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //suodatetaan DataGridiin näkyviin vain valittu automerkki
            string merkki = cmbAutot.SelectedValue.ToString();
            var result = autot.Where(m => m.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
            NaytaKuva("autotalli.png");
        }
    }
}
