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

namespace Lab10._1
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

        private int trucks = 0;
        private int cars = 0;

        private void btnTrucks_Click(object sender, RoutedEventArgs e)
        {
            trucks ++;
            //ei int trucks = +1;
            string luku = trucks.ToString();
            txbTrucks.Text = luku;

        }

        private void btnCars_Click(object sender, RoutedEventArgs e)
        {
            cars++;
            string luku = cars.ToString();
            txbCars.Text = luku;
        }
    }
}
