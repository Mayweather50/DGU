﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF_Biblioteka.Account
{
    /// <summary>
    /// Логика взаимодействия для SoundsPage.xaml
    /// </summary>
    public partial class SoundsPage : Page
    {
        public SoundsPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Process.Start("F:/audio/02 Prestuplenie i nakazanie chast 1 gl 2 - Bibe.ru.mp3");

        }
    }
}