using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }


        private void Button_Sapiens(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\Files\yuval_noj_harari-sapiens-1488915077.pdf";


            Process.Start(path);

        }
      

        private void Harry_Potter(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\Files\dzhoan_rouling-garri_potter_i_filosofskij_kamen-1488912307.pdf";


            Process.Start(path);

        }

        private void Pofigizm(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/Book/yuval_noj_harari_21_urok_dlya_xxi_veka_s_kommentirovannim_5e.pdf");


        }

        private void Hrenovo(object sender, RoutedEventArgs e)
        {


            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/Book/King_Billi-Sammers.yKOj_w.668672.pdf");

        }
        private void Put(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\Files\Robbins_Put-kak-uskorit-prodvizhenie-k-finansovoy-svobode.649913.pdf";


            Process.Start(path);

        }

        private void Hobit(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\Files\dzhon_ronald_ruel_tolkin-hobbit-1489524236.pdf";


            Process.Start(path);

        }

        private void Reinkarnator(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\Files\yuliya_rizhenkova-reinkarnator-60d4b7858dc15.pdf";


            Process.Start(path);


        }

        private void Parfume(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\Files\patrik_zyuskind_parfyumer_istori.pdf";


            Process.Start(path);


        }

        private void Button_Fahrenheit(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\Files\rej_bredberi-451_gradus_po_farengejtu-1489233476.pdf";


            Process.Start(path);

        }

        private void Button_Beda(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\Files\rej_bredberi_miri_reya_bredberi_.pdf";


            Process.Start(path);

        }
    }
}
