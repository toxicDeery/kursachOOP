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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
        }
        int ids = 0;

        private void ComboEl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboEl.SelectedIndex == 1)
            {
                ComboId.Items.Clear();
                foreach(Door i in DB.doors)
                {
                    ComboId.Items.Add(i.thisNumber);
                }
            }
        }

        private void outE_Click(object sender, RoutedEventArgs e)
        {
            if (ComboEl.SelectedIndex == 1)
            {
                for (int i = 0; i < DB.doors.Count; i++)
                {
                    if (DB.doors[ids].thisNumber == ComboId.Text)
                    {
                        Text1.Text = DB.doors[ids].thisNumber;
                        Text2.Text = DB.doors[ids].thisName;
                        Text3.Text = DB.doors[ids].thisLength;
                        ids = i;
                    }
                }
            }
        }
    }
}
