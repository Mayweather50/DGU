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

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button_vremeni(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/stiven_uilyam_hoking_kratchajsha_1.pdf");


        }



        private void Button_Kvantovie_miri(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");


        }


        private void Button_Astrofizika(object sender, RoutedEventArgs e)
        {




            string path = Directory.GetCurrentDirectory() + @"\Files\list.pdf";


            Process.Start(path);


        }




        private void Button_Stiven_hoking(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/stiven_uilyam_hoking-kratkaya_istoriya_vremeni-1489046677.pdf");


        }


        private void Button_Gen(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/klinton_richard_dokinz-egoistichnij_gen-1489167316.pdf");


        }


        private void Button_Raduga(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/fenni_flegg-stoya_pod_radugoj-1490550761.pdf");


        }






        private void Button_Dostoevsky(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/fedor_mihajlovich_dostoevskij_pr.pdf");


        }

        private void Button_Zhivie(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/varvara_nikolaevna_enal-mi_ostaemsya_svobodnimi-1497283941.pdf");


        }


        private void Button_Instityt(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/stiven_king-institut-5e1ec6dd669a3.pdf");


        }




        private void Button_Zhakomin(object sender, RoutedEventArgs e)
        {
            Process.Start("C:/Users/myrta/Downloads/C_4_0_polnoe_rukovodstvo_Shildt_Gerbert.pdf");


        }


        private void Bogatiy(object sender, RoutedEventArgs e)
        {
            string path = "F:/My_Work-main/WPF_Biblioteka/bin/Debug/Files/robert_toru_kijosaki-bogatij_papa_bednij_papa-1488894026.pdf";

            Process.Start(path);
        }

        private void kupol(object sender, RoutedEventArgs e)
        {
            string path = "F:/My_Work-main/WPF_Biblioteka/bin/Debug/Files/stiven_king-pod_kupolom-1500602185.pdf";


            Process.Start(path);

        }

        private void Sumerek(object sender, RoutedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\Files\rej_bredberi-451_gradus_po_farengejtu-1489233476.pdf";


            Process.Start(path);

        }

        private void Putin(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/Files/viktor_ivanovich_ilyuhin_putin_p.pdf");
        }



        private void Usa(object sender, RoutedEventArgs e)
        {
            string path = "F:/My_Work-main/WPF_Biblioteka/bin/Debug/Files/Новая_исповедь_экономического_убийцы.pdf";


            Process.Start(path);

        }
    }
}
