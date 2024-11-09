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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            private string imgsource1 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\PandaBossTime\My Pictures\1589114980_preview_subnautica-okean-sushchestvo-batiskaf-glaza-zmeia.jpg";
            private string imgsource2 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\PandaBossTime\My Pictures\31.png";
        public MainWindow()
        {
            InitializeComponent();
        }

    private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            this.Close();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(imgsource1));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(imgsource2));
        }
    }
}
