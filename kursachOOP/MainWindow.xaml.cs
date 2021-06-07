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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace kursachOOP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.Show();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            doorsRefresh();
            balconRefresh();
            windRefresh();
            prohodRefresh();
            entroomRefresh();
            pomeshRefresh();
        }
        private void doorsRefresh()
        {
            Doors.ItemsSource = DB.doors;
            Doors.Items.Refresh();
        }
        private void balconRefresh()
        {
            Balcon.ItemsSource = DB.balconies;
            Balcon.Items.Refresh();
        }
        private void windRefresh()
        {
            Wind.ItemsSource = DB.windowws;
            Wind.Items.Refresh();
        }
        private void prohodRefresh()
        {
            prohodn.ItemsSource = DB.ents;
            prohodn.Items.Refresh();
        }
        private void entroomRefresh()
        {
            entrroom.ItemsSource = DB.cls;
            entrroom.Items.Refresh();
        }
        private void pomeshRefresh()
        {
            Pomesh.ItemsSource = DB.place;
            Pomesh.Items.Refresh();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            Delete de = new Delete();
            de.Show();
        }
    }
}
