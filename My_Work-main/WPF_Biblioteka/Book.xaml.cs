using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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
    /// Логика взаимодействия для Book.xaml
    /// </summary>
    public partial class Book : Page
    {
        public Book()
        {
            InitializeComponent();
        }


        private void Button_vremeni(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/stiven_uilyam_hoking_kratchajsha (1).pdf");


        }   
        
        
        
        private void Button_Kvantovie_miri(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/Kerroll_Vselennaya-Proishozhdenie-zhizni-smysl-nashego-sushchestvovaniya-i-ogromnyy-kosmos.512439.fb2.pdf");


        }      
        
        
        private void Button_Astrofizika(object sender, RoutedEventArgs e)
        {
          
          


          


            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/Tayson_Astrofizika-s-kosmicheskoy-skorostyu-ili-Velikie-tayny-Vselennoy-dlya-teh-komu-nekogda.523056.fb2.pdf");


        }   
        
        
        
        
        private void Button_Stiven_hoking(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/HHoking_Kratkaya-istoriya-vremeni-Ot-Bolshogo-vzryva-do-chernyh-dyr.548595.fb2.pdf");


        }
          
        
        private void Button_Gen(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/Dokinz_Egoistichnyy-gen.653430.pdf");


        }  
        
        
        private void Button_Raduga(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/fenni_flegg-stoya_pod_radugoj-1490550761 (1).pdf");


        }






        private void Button_Dostoevsky(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/fedor_mihajlovich_dostoevskij_pr (1).pdf");


        }

        private void Button_Zhivie(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/varvara_nikolaevna_enal_mi_mozhe.pdf");


        }   
        
        
        private void Button_Instityt(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/_--5e9e1a77ab2ee.pdf");


        } 
        
        
        
        
        private void Button_Zhakomin(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/Report_13_20220621_.pdf");


        }
    }
}
