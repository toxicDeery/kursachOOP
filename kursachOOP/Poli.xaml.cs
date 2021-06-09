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
    /// Логика взаимодействия для Poli.xaml
    /// </summary>
    public partial class Poli : Window
    {
        public Poli()
        {
            InitializeComponent();
            Doors.ItemsSource = DB.doors;
            Doors.Items.Refresh();
            Pomesh.ItemsSource = DB.place;
            Pomesh.Items.Refresh();
        }

        private void poly_Click(object sender, RoutedEventArgs e)
        {
            ElementBuild operation = DB.doors[Doors.SelectedIndex];
            list1.Items.Add(operation.display());
        }

        private void poly1_Click(object sender, RoutedEventArgs e)
        {
            ElementBuild operation = DB.place[Pomesh.SelectedIndex];
            list2.Items.Add(operation.display());
        }
    }
}
