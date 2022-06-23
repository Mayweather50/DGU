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
using System.Windows.Shapes;

namespace WPF_Biblioteka
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public List<User> user = new List<User>();
        public void LoadUser(List<User> _user)
        {
            userList.Items.Clear(); // очищаем лист с элементами

            for (int i = 0; i < _user.Count; i++) // перебираем элементы
            {
                userList.Items.Add(_user[i]); // добавляем элементы в ListBox
            }
        }
   

        public Window1()
        {
            InitializeComponent();




        }

        private void ActiveFilter(object sender, RoutedEventArgs e)
        {
            List<User> newUsers = new List<User>();
            newUsers = user;

            //if (genderFilter.SelectedIndex == 0)
            //    newUsers = user.FindAll(x => x.book == "Преступление и наказание");

            //else
            //    newUsers = user.FindAll(x => x.book == "Институт");

            //newUsers = newUsers.FindAll(x => x.name.Contains(genderFilter.Text));

            //var foundBooks = newUsers.Where(item => item.name == genderFilter.Text.ToLower());

            //var results = newUsers.Where(item => item.name == genderFilter.Text.ToLower()).FirstOrDefault();
            var result = newUsers.FindAll(s => s.name == genderFilter.Text);
            if (genderFilter.Text == "Достоевский")
            {
                Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/fedor_mihajlovich_dostoevskij_pr (1).pdf");

            }

            if(genderFilter.Text=="Ричард Докинз")
            {
                Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/Dokinz_Egoistichnyy-gen.653430.pdf");

            }

            if(genderFilter.Text=="Стивен Хокинг")
            {
                Process.Start("F:/My_Work-main/WPF_Biblioteka/bin/Debug/book/HHoking_Kratkaya-istoriya-vremeni-Ot-Bolshogo-vzryva-do-chernyh-dyr.548595.fb2.pdf");

            }





            LoadUser(result);
        }


        private void MaxBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        } 
        
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }








        public class User
        {
            public string name { get; set; }
            public string book { get; set; }

            public User(string _name,   string _book)
            {
                this.name = _name;
                this.book = _book;
            }

          





        }
        public string path = Directory.GetCurrentDirectory() + @"\Files\list.pdf";


        public void AddUser(List<User> _user)
        {
            userList.Items.Clear(); 
            _user.Add(new User(nameFilter.Text, authorFilter.Text));

            for (int i = 0; i < _user.Count; i++) 
            {
                userList.Items.Add(_user[i]);

            }
        }



        //public void AddName(List<User> _user)
        //{
        //    userList.Items.Clear();
        //    _user.Add(new User("",  authorFilter.Text));

        //    for (int i = 0; i < _user.Count; i++)
        //    {
        //        userList.Items.Add(_user[i]);
        //    }
        //}


        private void Add(object sender, RoutedEventArgs e)
        {
           
        
            
         
            AddUser(user);
            //AddName(user);

        }

        public void Remove(List<User> _user)
        {
            userList.Items.Clear();
            _user.Remove(new User(nameFilter.Text, authorFilter.Text));

            for (int i = 0; i < _user.Count; i++)
            {
                userList.Items.Add(_user[i]);
            }


        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            userList.Items.Clear();
           if(userList.SelectedIndex == 0)
           {

                nameFilter.Text = null;

           }


        }

        private void Option_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(path);

        }

        //private void Name_Click(object sender, RoutedEventArgs e)
        //{
        //    AddName(user);
        //}
    }
}
