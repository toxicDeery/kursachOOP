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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void TypeEl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TypeEl.SelectedIndex == 0)
            {
                pomeshStackPanel.Visibility = Visibility.Visible;
            }

            if (TypeEl.SelectedIndex == 1)
            {

            }

            if (TypeEl.SelectedIndex == 2)
            {

            }

        }
    }
}
