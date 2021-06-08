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
using System.Windows.Shapes;

namespace kursachOOP
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(MainWindow window)
        {
            InitializeComponent();
            text8.Visibility = Visibility.Collapsed;
            text9.Visibility = Visibility.Collapsed;
            text10.Visibility = Visibility.Hidden;
            text11.Visibility = Visibility.Collapsed;
            text12.Visibility = Visibility.Collapsed;
            checkRoom.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Collapsed;
            label2.Visibility = Visibility.Collapsed;
            label3.Visibility = Visibility.Collapsed;
            label4.Visibility = Visibility.Collapsed;
            label5.Visibility = Visibility.Hidden;
            win = window;
        }
        MainWindow win;
        string id = "";
        AddElemClass add = new AddElemClass();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEl(id, Text1.Text, text2.Text, text3.Text, text4.Text, text5.Text, text6.Text, text7.Text, text8.Text, text9.Text, text11.Text, text12.Text, text10.Text);
            MessageBox.Show("Элемент добавлен");
            
            
        }

        public void AddEl(string id, string num, string Name, string length, string width, string height, string x, string y, string test, string test1, string test2, string test3, string test4)
        {
            if (id == "0")
            {
                Placement pl = new Placement(num, Name, length, height, width, x, y, test, test1);
                DB.place.Add(pl);
                DelegateC newdelegate = new DelegateC();
                
                win.listbox1.Items.Add(newdelegate.Displayed(pl));
            }
            
            
            if (id == "1")
            {
                Door dr = new Door(num, Name, length, height, width, x, y, test, test1);
                DB.doors.Add(dr);
            }
            if (id == "2")
            {
                Windoww wind = new Windoww(num, Name, length, height, width, x, y, test, test1);
                DB.windowws.Add(wind);
            }
            if (id == "3")
            {
                Balcony balc = new Balcony(num, Name, length, height, width, x, y, test);
                DB.balconies.Add(balc);
            }

            if (id == "5")
            {
                EntRoom ent = new EntRoom(num, Name, length, height, width, x, y, test, test1, test2, test3, test4);
                DB.ents.Add(ent);
            }

            if (id == "6")
            {
                ClRoom cl = new ClRoom(num, Name, length, height, width, x, y, test, test1, test2, test3);
                DB.cls.Add(cl);

            }
        }
        private void TypeEl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            checkRoom.Visibility = Visibility.Hidden;
            text10.Visibility = Visibility.Hidden;
            
            if (TypeEl.SelectedIndex == 0)
            {
                id = "0";
                text8.Visibility = Visibility.Visible;
                text9.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label1.Content = "Коды дверей";
                label2.Content = "Коды окон";
                label3.Visibility = Visibility.Collapsed;
                label4.Visibility = Visibility.Collapsed;
                text11.Visibility = Visibility.Collapsed;
                text12.Visibility = Visibility.Collapsed;
            }

            if (TypeEl.SelectedIndex == 1)
            {
                id = "1";
                text8.Visibility = Visibility.Visible;
                text9.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label1.Content = "Тип двери";
                label2.Content = "Материал";
            }

            if (TypeEl.SelectedIndex == 2)
            {
                id = "2";
                text8.Visibility = Visibility.Visible;
                text9.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label1.Content = "Материал";
                label2.Content = "Кол-во створок";
            }
            if(TypeEl.SelectedIndex == 3)
            {
                id = "3";
                text8.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label1.Content = "Тип балкона";
                label2.Visibility = Visibility.Collapsed;
                label3.Visibility = Visibility.Collapsed;
                label4.Visibility = Visibility.Collapsed;
                text9.Visibility = Visibility.Collapsed;
                text11.Visibility = Visibility.Collapsed;
                text12.Visibility = Visibility.Collapsed;
            }
            if (TypeEl.SelectedIndex == 4)
            {
                id = "6";
                checkRoom.Visibility = Visibility.Visible;
                text8.Visibility = Visibility.Visible;
                text9.Visibility = Visibility.Visible;
                text11.Visibility = Visibility.Visible;
                text12.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label3.Visibility = Visibility.Visible;
                label4.Visibility = Visibility.Visible;
                label1.Content = "Назначение";
                label2.Content = "Тип отделки";
                label3.Content = "Коды дверей";
                label4.Content = "Коды окон";

            }


        }

        private void checkRoom_Checked(object sender, RoutedEventArgs e)
        {
            

        }

        private void checkRoom_Click(object sender, RoutedEventArgs e)
        {
            if (checkRoom.IsChecked == true)
            {
                id = "5";
                text10.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Visible;
                label5.Content = "Куда можно попасть?";

            }
            if (checkRoom.IsChecked == false)
            {
                id = "6";
                text10.Visibility = Visibility.Hidden;
                label5.Visibility = Visibility.Hidden;

            }
        }
    }
}
