using System;
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

namespace WPF_Biblioteka.СС
{
    /// <summary>
    /// Логика взаимодействия для Novinki.xaml
    /// </summary>
    public partial class Novinki : Page
    {
        public Novinki()
        {
            InitializeComponent();
        }
        private void frai(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/Fray_Eho_1_Labirinty-Eho-Tom-1.451569.fb2.pdf");


        }
        private void idol(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/Matveev_Idoly-vlasti-ot-Heopsa-do-Putina.318054.fb2 (1).pdf");


        }

        private void stiven_king(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/King_Trilogiya-Billa-Hodzhesa_2_Kto-nashel-beret-sebe.427661.fb2.pdf");


        } 
        
        private void Steklo(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/Skorenko_Steklo.646336.fb2.pdf");


        }   
        private void WPFbook(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");


        }
    }
}
