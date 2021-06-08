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
    /// Логика взаимодействия для Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete1_Click(object sender, RoutedEventArgs e)
        {
            delplace();
            delDoor();
            delWindow();
            delBalc();
            delEntR();
            delClR();
            MessageBox.Show("Элемент удален");
        }
        private void delplace()
        {
            if (DelCombo.SelectedIndex == 0)
            {
                for (int i = 0; i < DB.place.Count; i++)
                {
                    if (DB.place[i].thisNumber == delidCB.Text)
                    {
                        DB.place.RemoveAt(i);
                    }
                }
            }
        }
        private void delDoor()
        {
            if (DelCombo.SelectedIndex == 1)
            {
                for (int i = 0; i < DB.doors.Count; i++)
                {
                    if (DB.doors[i].thisNumber == delidCB.Text)
                    {
                        DB.doors.RemoveAt(i);
                    }
                }
            }
        }
        private void delWindow()
        {
            if (DelCombo.SelectedIndex == 2)
            {
                for (int i = 0; i < DB.windowws.Count; i++)
                {
                    if (DB.windowws[i].thisNumber == delidCB.Text)
                    {
                        DB.windowws.RemoveAt(i);
                    }
                }
            }
        }
        private void delBalc()
        {
            if (DelCombo.SelectedIndex == 3)
            {
                for (int i = 0; i < DB.balconies.Count; i++)
                {
                    if (DB.balconies[i].thisNumber == delidCB.Text)
                    {
                        DB.balconies.RemoveAt(i);
                    }
                }
            }
        }
        private void delEntR()
        {
            if (DelCombo.SelectedIndex == 4)
            {
                for (int i = 0; i < DB.ents.Count; i++)
                {
                    if (DB.ents[i].thisNumber == delidCB.Text)
                    {
                        DB.ents.RemoveAt(i);
                    }
                }
            }
        }
        private void delClR()
        {
            if (DelCombo.SelectedIndex == 5)
            {
                for (int i = 0; i < DB.cls.Count; i++)
                {
                    if (DB.cls[i].thisNumber == delidCB.Text)
                    {
                        DB.cls.RemoveAt(i);
                    }
                }
            }
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DelCombo.SelectedIndex == 0)
            {
                delidCB.Items.Clear();
                foreach (Placement i in DB.place)
                {
                    delidCB.Items.Add(i.thisNumber);
                }
                
            }
            if (DelCombo.SelectedIndex == 1)
            {
                delidCB.Items.Clear();
                foreach (Door i in DB.doors)
                {
                    delidCB.Items.Add(i.thisNumber);
                }
            }
            if (DelCombo.SelectedIndex == 2)
            {
                delidCB.Items.Clear();
                foreach (Windoww i in DB.windowws)
                {
                    delidCB.Items.Add(i.thisNumber);
                }
            }
            if (DelCombo.SelectedIndex == 3)
            {
                delidCB.Items.Clear();
                foreach (Balcony i in DB.balconies)
                {
                    delidCB.Items.Add(i.thisNumber);
                }
            }
            if (DelCombo.SelectedIndex == 5)
            {
                delidCB.Items.Clear();
                foreach (ClRoom i in DB.cls)
                {
                    delidCB.Items.Add(i.thisNumber);
                }
            }
            if (DelCombo.SelectedIndex == 4)
            {
                delidCB.Items.Clear();
                foreach (EntRoom i in DB.ents)
                {
                    delidCB.Items.Add(i.thisNumber);
                }
            }
        }
    }
}
