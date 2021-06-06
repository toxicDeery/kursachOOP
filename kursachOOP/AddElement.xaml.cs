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
        public Window1()
        {
            InitializeComponent();
            pomeshLabel.Visibility = Visibility.Hidden;
            pomeshStackPanel.Visibility = Visibility.Hidden;
            doorStackPanel.Visibility = Visibility.Hidden;
            doorLabel.Visibility = Visibility.Hidden;
            windowStackPanel.Visibility = Visibility.Hidden;
            windowLabel.Visibility = Visibility.Hidden;
            balconyStackPanel.Visibility = Visibility.Hidden;
            balconyLabel.Visibility = Visibility.Hidden;
            roomStackPanel.Visibility = Visibility.Hidden;
            roomLabel.Visibility = Visibility.Hidden;
        }
        string id = "";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TypeEl.SelectedIndex == 0)
            {

            }
        }

        private void TypeEl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pomeshLabel.Visibility = Visibility.Hidden;
            pomeshStackPanel.Visibility = Visibility.Hidden;
            doorStackPanel.Visibility = Visibility.Hidden;
            doorLabel.Visibility = Visibility.Hidden;
            windowStackPanel.Visibility = Visibility.Hidden;
            windowLabel.Visibility = Visibility.Hidden;
            balconyStackPanel.Visibility = Visibility.Hidden;
            balconyLabel.Visibility = Visibility.Hidden;
            roomStackPanel.Visibility = Visibility.Hidden;
            roomLabel.Visibility = Visibility.Hidden;
            if (TypeEl.SelectedIndex == 0)
            {
                id = "0";
                pomeshLabel.Visibility = Visibility.Visible;
                pomeshStackPanel.Visibility = Visibility.Visible;
            }

            if (TypeEl.SelectedIndex == 1)
            {
                id = "1";
                doorStackPanel.Visibility = Visibility.Visible;
                doorLabel.Visibility = Visibility.Visible;
            }

            if (TypeEl.SelectedIndex == 2)
            {
                id = "2";
                windowStackPanel.Visibility = Visibility.Visible;
                windowLabel.Visibility = Visibility.Visible;
            }
            if(TypeEl.SelectedIndex == 3)
            {
                id = "3";
                balconyStackPanel.Visibility = Visibility.Visible;
                balconyLabel.Visibility = Visibility.Visible;
            }
            if (TypeEl.SelectedIndex == 4)
            {
                id = "4";
                roomStackPanel.Visibility = Visibility.Visible;
                roomLabel.Visibility = Visibility.Visible;
            }


        }
    }
}
