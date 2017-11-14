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

namespace Lab10._2
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

        private void txtOstettavasumma_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double maksusumma;
                double muunnettuosto;
                if (double.TryParse(txtOstettavasumma.Text, out muunnettuosto))
                {
                    if (cmbValuutat.Text == "Yhdysvallat USD")
                    {
                        maksusumma = muunnettuosto * 0.8997;
                        string muunnettumaksu = maksusumma.ToString("0.00");
                        txbMaksettavasumma.Text = muunnettumaksu;
                        txbMaksuvaluutta.Text = "Suomi, Eur";
                    }

                    else if (cmbValuutat.Text == "Suomi EUR")
                    {
                        maksusumma = muunnettuosto / 0.8997;
                        string muunnettumaksu = maksusumma.ToString("0.00");
                        txbMaksettavasumma.Text = muunnettumaksu;
                        txbMaksuvaluutta.Text = "Yhdysvallat, USD";
                    }
                }
                else
                    txtOstettavasumma.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
