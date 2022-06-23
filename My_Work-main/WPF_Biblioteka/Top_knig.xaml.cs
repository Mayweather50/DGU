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
    /// Логика взаимодействия для Top_knig.xaml
    /// </summary>
    public partial class Top_knig : Page
    {
        public Top_knig()
        {
            InitializeComponent();
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
            string path = Directory.GetCurrentDirectory() + @"/Files/rej_bredberi-451_gradus_po_farengejtu-1489233476.pdf";


            Process.Start(path);

        }

        private void Putin(object sender, RoutedEventArgs e)
        {
            Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/Book/viktor_ivanovich_ilyuhin_putin_p.pdf");
        }

      

        private void Usa(object sender, RoutedEventArgs e)
        {
            string path = "F:/My_Work-main/WPF_Biblioteka/bin/Debug/Files/Новая_исповедь_экономического_убийцы.pdf";


            Process.Start(path);

        }
    }
}
