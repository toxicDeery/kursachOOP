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
            Text8.Visibility = Visibility.Collapsed;
            Text9.Visibility = Visibility.Collapsed;
            Text10.Visibility = Visibility.Collapsed;
            Text11.Visibility = Visibility.Collapsed;
            Text12.Visibility = Visibility.Collapsed;
            
            label1.Visibility = Visibility.Collapsed;
            label2.Visibility = Visibility.Collapsed;
            label3.Visibility = Visibility.Collapsed;
            label4.Visibility = Visibility.Collapsed;
            label5.Visibility = Visibility.Collapsed;
        }
        int ids = 0;

        private void ComboEl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboEl.SelectedIndex == 0)
            {
                ComboId.Items.Clear();
                foreach (Placement i in DB.place)
                {
                    ComboId.Items.Add(i.thisNumber);
                }
                Text8.Visibility = Visibility.Visible;
                Text9.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label1.Content = "Коды дверей";
                label2.Content = "Коды окон";
                label3.Visibility = Visibility.Collapsed;
                label4.Visibility = Visibility.Collapsed;
                label5.Visibility = Visibility.Collapsed;
                Text11.Visibility = Visibility.Collapsed;
                Text12.Visibility = Visibility.Collapsed;
                Text10.Visibility = Visibility.Collapsed;
            }
            if (ComboEl.SelectedIndex == 1)
            {
                ComboId.Items.Clear();
                foreach(Door i in DB.doors)
                {
                    ComboId.Items.Add(i.thisNumber);
                }
                Text8.Visibility = Visibility.Visible;
                Text9.Visibility = Visibility.Visible;
                Text10.Visibility = Visibility.Collapsed;
                Text11.Visibility = Visibility.Collapsed;
                Text12.Visibility = Visibility.Collapsed;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label3.Visibility = Visibility.Collapsed;
                label4.Visibility = Visibility.Collapsed;
                label5.Visibility = Visibility.Collapsed;
                label1.Content = "Тип двери";
                label2.Content = "Материал";
            }
            if (ComboEl.SelectedIndex == 2)
            {
                ComboId.Items.Clear();
                foreach (Windoww i in DB.windowws)
                {
                    ComboId.Items.Add(i.thisNumber);
                }
                Text8.Visibility = Visibility.Visible;
                Text9.Visibility = Visibility.Visible;
                Text10.Visibility = Visibility.Collapsed;
                Text11.Visibility = Visibility.Collapsed;
                Text12.Visibility = Visibility.Collapsed;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label3.Visibility = Visibility.Collapsed;
                label4.Visibility = Visibility.Collapsed;
                label5.Visibility = Visibility.Collapsed;
                label1.Content = "Материал";
                label2.Content = "Кол-во створок";
            }
            if (ComboEl.SelectedIndex == 3)
            {
                ComboId.Items.Clear();
                foreach (Balcony i in DB.balconies)
                {
                    ComboId.Items.Add(i.thisNumber);
                }
                Text8.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label1.Content = "Тип балкона";
                label2.Visibility = Visibility.Collapsed;
                label3.Visibility = Visibility.Collapsed;
                label4.Visibility = Visibility.Collapsed;
                label5.Visibility = Visibility.Collapsed;
                Text9.Visibility = Visibility.Collapsed;
                Text10.Visibility = Visibility.Collapsed;
                Text11.Visibility = Visibility.Collapsed;
                Text12.Visibility = Visibility.Collapsed;
            }
            if (ComboEl.SelectedIndex == 5)
            {
                ComboId.Items.Clear();
                foreach (ClRoom i in DB.cls)
                {
                    ComboId.Items.Add(i.thisNumber);
                }
                
                Text8.Visibility = Visibility.Visible;
                Text9.Visibility = Visibility.Visible;
                Text10.Visibility = Visibility.Collapsed;
                Text11.Visibility = Visibility.Visible;
                Text12.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label3.Visibility = Visibility.Visible;
                label4.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Collapsed;
                label1.Content = "Назначение";
                label2.Content = "Тип отделки";
                label3.Content = "Коды дверей";
                label4.Content = "Коды окон";
            }
            if (ComboEl.SelectedIndex == 4)
            {
                ComboId.Items.Clear();
                foreach (EntRoom i in DB.ents)
                {
                    ComboId.Items.Add(i.thisNumber);
                }
                Text8.Visibility = Visibility.Visible;
                Text9.Visibility = Visibility.Visible;
                Text11.Visibility = Visibility.Visible;
                Text12.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label3.Visibility = Visibility.Visible;
                label4.Visibility = Visibility.Visible;
                label1.Content = "Назначение";
                label2.Content = "Тип отделки";
                label3.Content = "Коды дверей";
                label4.Content = "Коды окон";
                Text10.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Visible;
                label5.Content = "Куда можно попасть?";
            }

        }

        private void outE_Click(object sender, RoutedEventArgs e)
        {
            if (ComboEl.SelectedIndex == 0)
            {
                for (int i = 0; i < DB.place.Count; i++)
                {
                    if (DB.place[ids].thisNumber == ComboId.Text)
                    {
                        Text1.Text = DB.place[ids].thisNumber;
                        Text2.Text = DB.place[ids].thisName;
                        Text3.Text = DB.place[ids].thisLength;
                        Text4.Text = DB.place[ids].thisWidth;
                        Text5.Text = DB.place[ids].thisHeight;
                        Text6.Text = DB.place[ids].thisX;
                        Text7.Text = DB.place[ids].thisY;
                        Text8.Text = DB.place[ids].thisDoorCode;
                        Text9.Text = DB.place[ids].thisWindowCode;
                        ids = i;
                    }
                }
            }
            if (ComboEl.SelectedIndex == 1)
            {
                for (int i = 0; i < DB.doors.Count; i++)
                {
                    if (DB.doors[ids].thisNumber == ComboId.Text)
                    {
                        Text1.Text = DB.doors[ids].thisNumber;
                        Text2.Text = DB.doors[ids].thisName;
                        Text3.Text = DB.doors[ids].thisLength;
                        Text4.Text = DB.doors[ids].thisWidth;
                        Text5.Text = DB.doors[ids].thisHeight;
                        Text6.Text = DB.doors[ids].thisX;
                        Text7.Text = DB.doors[ids].thisY;
                        Text8.Text = DB.doors[ids].thisTypeDoor;
                        Text9.Text = DB.doors[ids].thisMateriald;
                        ids = i;
                    }
                }
            }
            if (ComboEl.SelectedIndex == 2)
            {
                for (int i = 0; i < DB.windowws.Count; i++)
                {
                    if (DB.windowws[ids].thisNumber == ComboId.Text)
                    {
                        Text1.Text = DB.windowws[ids].thisNumber;
                        Text2.Text = DB.windowws[ids].thisName;
                        Text3.Text = DB.windowws[ids].thisLength;
                        Text4.Text = DB.windowws[ids].thisWidth;
                        Text5.Text = DB.windowws[ids].thisHeight;
                        Text6.Text = DB.windowws[ids].thisX;
                        Text7.Text = DB.windowws[ids].thisY;
                        Text8.Text = DB.windowws[ids].thisMaterialw;
                        Text9.Text = DB.windowws[ids].thisStvor;
                        ids = i;
                    }
                }
            }
            if (ComboEl.SelectedIndex == 3)
            {
                for (int i = 0; i < DB.balconies.Count; i++)
                {
                    if (DB.balconies[ids].thisNumber == ComboId.Text)
                    {
                        Text1.Text = DB.balconies[ids].thisNumber;
                        Text2.Text = DB.balconies[ids].thisName;
                        Text3.Text = DB.balconies[ids].thisLength;
                        Text4.Text = DB.balconies[ids].thisWidth;
                        Text5.Text = DB.balconies[ids].thisHeight;
                        Text6.Text = DB.balconies[ids].thisX;
                        Text7.Text = DB.balconies[ids].thisY;
                        Text8.Text = DB.balconies[ids].thisTypeBalc;
                        ids = i;
                    }
                }
            }
            if (ComboEl.SelectedIndex == 4)
            {
                for (int i = 0; i < DB.ents.Count; i++)
                {
                    if (DB.ents[ids].thisNumber == ComboId.Text)
                    {
                        Text1.Text = DB.ents[ids].thisNumber;
                        Text2.Text = DB.ents[ids].thisName;
                        Text3.Text = DB.ents[ids].thisLength;
                        Text4.Text = DB.ents[ids].thisWidth;
                        Text5.Text = DB.ents[ids].thisHeight;
                        Text6.Text = DB.ents[ids].thisX;
                        Text7.Text = DB.ents[ids].thisY;
                        Text8.Text = DB.ents[ids].thisPurpose;
                        Text9.Text = DB.ents[ids].thisTypeoffin;
                        Text10.Text = DB.ents[ids].thisNextRoom;
                        Text11.Text = DB.ents[ids].thisDoorCode;
                        Text12.Text = DB.ents[ids].thisWindowCode;
                        ids = i;
                    }
                }
            }
            if (ComboEl.SelectedIndex == 5)
            {
                for (int i = 0; i < DB.cls.Count; i++)
                {
                    if (DB.cls[ids].thisNumber == ComboId.Text)
                    {
                        Text1.Text = DB.cls[ids].thisNumber;
                        Text2.Text = DB.cls[ids].thisName;
                        Text3.Text = DB.cls[ids].thisLength;
                        Text4.Text = DB.cls[ids].thisWidth;
                        Text5.Text = DB.cls[ids].thisHeight;
                        Text6.Text = DB.cls[ids].thisX;
                        Text7.Text = DB.cls[ids].thisY;
                        Text8.Text = DB.cls[ids].thisPurpose;
                        Text9.Text = DB.cls[ids].thisTypeoffin;
                        Text11.Text = DB.cls[ids].thisDoorCode;
                        Text12.Text = DB.cls[ids].thisWindowCode;
                        ids = i;
                    }
                }
            }

        }

        private void Edit1_Click(object sender, RoutedEventArgs e)
        {
            placeEdit();
            doorEdit();
            windowEdit();
            balconyEdit();
            entREdit();
            clsREdit();
            MessageBox.Show("Элемент отредактирован");
        }
        private void placeEdit()
        {
            if (ComboEl.SelectedIndex == 0)
            {
                for (int i = 0; i < DB.place.Count; i++)
                {
                    if (DB.place[ids].thisNumber == ComboId.Text)
                    {
                        DB.place[ids].thisNumber = Text1.Text;
                        DB.place[ids].thisName = Text2.Text;
                        DB.place[ids].thisLength = Text3.Text;
                        DB.place[ids].thisWidth = Text4.Text;
                        DB.place[ids].thisHeight = Text5.Text;
                        DB.place[ids].thisX = Text6.Text;
                        DB.place[ids].thisY = Text7.Text;
                        DB.place[ids].thisDoorCode = Text8.Text;
                        DB.place[ids].thisWindowCode = Text9.Text;
                        ids = i;
                    }
                }
            }
        }
        private void doorEdit()
        {
            if (ComboEl.SelectedIndex == 1)
            {
                for (int i = 0; i < DB.doors.Count; i++)
                {
                    if (DB.doors[ids].thisNumber == ComboId.Text)
                    {
                        DB.doors[ids].thisNumber = Text1.Text;
                        DB.doors[ids].thisName = Text2.Text;
                        DB.doors[ids].thisLength = Text3.Text;
                        DB.doors[ids].thisWidth = Text4.Text;
                        DB.doors[ids].thisHeight = Text5.Text;
                        DB.doors[ids].thisX = Text6.Text;
                        DB.doors[ids].thisY = Text7.Text;
                        DB.doors[ids].thisTypeDoor = Text8.Text;
                        DB.doors[ids].thisMateriald = Text9.Text;
                        ids = i;
                    }
                }
            }
        }
        private void windowEdit()
        {
            if (ComboEl.SelectedIndex == 2)
            {
                for (int i = 0; i < DB.windowws.Count; i++)
                {
                    if (DB.windowws[ids].thisNumber == ComboId.Text)
                    {
                        DB.windowws[ids].thisNumber = Text1.Text;
                        DB.windowws[ids].thisName = Text2.Text;
                        DB.windowws[ids].thisLength = Text3.Text;
                        DB.windowws[ids].thisWidth = Text4.Text;
                        DB.windowws[ids].thisHeight = Text5.Text;
                        DB.windowws[ids].thisX = Text6.Text;
                        DB.windowws[ids].thisY = Text7.Text;
                        DB.windowws[ids].thisMaterialw = Text8.Text;
                        DB.windowws[ids].thisStvor = Text9.Text;
                        ids = i;
                    }
                }
            }
        }
        private void balconyEdit()
        {
            if (ComboEl.SelectedIndex == 3)
            {
                for (int i = 0; i < DB.balconies.Count; i++)
                {
                    if (DB.balconies[ids].thisNumber == ComboId.Text)
                    {
                        DB.balconies[ids].thisNumber = Text1.Text;
                        DB.balconies[ids].thisName = Text2.Text;
                        DB.balconies[ids].thisLength = Text3.Text;
                        DB.balconies[ids].thisWidth = Text4.Text;
                        DB.balconies[ids].thisHeight = Text5.Text;
                        DB.balconies[ids].thisX = Text6.Text;
                        DB.balconies[ids].thisY = Text7.Text;
                        DB.balconies[ids].thisTypeBalc = Text8.Text;
                        ids = i;
                    }
                }
            }
        }
        private void entREdit()
        {
            if (ComboEl.SelectedIndex == 4)
            {
                for (int i = 0; i < DB.ents.Count; i++)
                {
                    if (DB.ents[ids].thisNumber == ComboId.Text)
                    {
                        DB.ents[ids].thisNumber = Text1.Text;
                        DB.ents[ids].thisName = Text2.Text;
                        DB.ents[ids].thisLength = Text3.Text;
                        DB.ents[ids].thisWidth = Text4.Text;
                        DB.ents[ids].thisHeight = Text5.Text;
                        DB.ents[ids].thisX = Text6.Text;
                        DB.ents[ids].thisY = Text7.Text;
                        DB.ents[ids].thisPurpose = Text8.Text;
                        DB.ents[ids].thisTypeoffin = Text9.Text;
                        DB.ents[ids].thisNextRoom = Text10.Text;
                        DB.ents[ids].thisDoorCode = Text11.Text;
                        DB.ents[ids].thisWindowCode = Text12.Text;
                        ids = i;
                    }
                }
            }
        }
        private void clsREdit()
        {
            if (ComboEl.SelectedIndex == 5)
            {
                for (int i = 0; i < DB.cls.Count; i++)
                {
                    if (DB.cls[ids].thisNumber == ComboId.Text)
                    {
                        DB.cls[ids].thisNumber = Text1.Text;
                        DB.cls[ids].thisName = Text2.Text;
                        DB.cls[ids].thisLength = Text3.Text;
                        DB.cls[ids].thisWidth = Text4.Text;
                        DB.cls[ids].thisHeight = Text5.Text;
                        DB.cls[ids].thisX = Text6.Text;
                        DB.cls[ids].thisY = Text7.Text;
                        DB.cls[ids].thisPurpose = Text8.Text;
                        DB.cls[ids].thisTypeoffin = Text9.Text;
                        DB.cls[ids].thisDoorCode = Text11.Text;
                        DB.cls[ids].thisWindowCode = Text12.Text;
                        ids = i;
                    }
                }
            }
        }
    }
    }
