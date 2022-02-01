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

namespace logikhra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush barva1;
        Brush barva2;
        Brush barva3;
        Brush barva4;
        public MainWindow()
        {
            InitializeComponent();
            NastavVariantu0();
            NastavBarvyPC();
            ZiskejBarvu();
            Title = $"{barva1} - {barva2} - {barva3} - {barva4}";
        }

        private void EllipseMouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse Ellipse = (Ellipse)sender;

            if (Ellipse.Fill == Brushes.Gray)
            {
                Ellipse.Fill = Brushes.Red;
            }
            else if (Ellipse.Fill == Brushes.Red)
            {
                Ellipse.Fill = Brushes.Green;
            }
            else if (Ellipse.Fill == Brushes.Green)
            {
                Ellipse.Fill = Brushes.Blue;
            }
            else if (Ellipse.Fill == Brushes.Blue)
            {
                Ellipse.Fill = Brushes.Yellow;
            }
            else if (Ellipse.Fill == Brushes.Yellow)
            {
                Ellipse.Fill = Brushes.Orange;
            }
            else if (Ellipse.Fill == Brushes.Orange)
            {
                Ellipse.Fill = Brushes.Purple;
            }
            else if (Ellipse.Fill == Brushes.Purple)
            {
                Ellipse.Fill = Brushes.Red;
            }
        }
        private void NastavElipsuEnabled(Ellipse Ellipse)
        {
            Ellipse.IsEnabled = true;
            Ellipse.Fill = Brushes.Gray;
            Ellipse.Stroke = Brushes.Black;
            Ellipse.Cursor = Cursors.Hand;
        }
        private void NastavElipsuDisabled(Ellipse Ellipse)
        {
            Ellipse.IsEnabled = false;
            Ellipse.Fill = Brushes.White;
            Ellipse.Stroke = Brushes.Gray;
        }
        private void NastavVariantu0()
        {
            NastavElipsuEnabled(Ellipse_0_0);
            NastavElipsuEnabled(Ellipse_0_1);
            NastavElipsuEnabled(Ellipse_0_2);
            NastavElipsuEnabled(Ellipse_0_3);

            NastavElipsuDisabled(Ellipse_1_0);
            NastavElipsuDisabled(Ellipse_1_1);
            NastavElipsuDisabled(Ellipse_1_2);
            NastavElipsuDisabled(Ellipse_1_3);

            NastavElipsuDisabled(Ellipse_2_0);
            NastavElipsuDisabled(Ellipse_2_1);
            NastavElipsuDisabled(Ellipse_2_2);
            NastavElipsuDisabled(Ellipse_2_3);

            NastavElipsuDisabled(Ellipse_3_0);
            NastavElipsuDisabled(Ellipse_3_1);
            NastavElipsuDisabled(Ellipse_3_2);
            NastavElipsuDisabled(Ellipse_3_3);

            NastavElipsuDisabled(Ellipse_4_0);
            NastavElipsuDisabled(Ellipse_4_1);
            NastavElipsuDisabled(Ellipse_4_2);
            NastavElipsuDisabled(Ellipse_4_3);

            NastavElipsuDisabled(Ellipse_5_0);
            NastavElipsuDisabled(Ellipse_5_1);
            NastavElipsuDisabled(Ellipse_5_2);
            NastavElipsuDisabled(Ellipse_5_3);

            NastavElipsuDisabled(Ellipse_6_0);
            NastavElipsuDisabled(Ellipse_6_1);
            NastavElipsuDisabled(Ellipse_6_2);
            NastavElipsuDisabled(Ellipse_6_3);

            NastavElipsuDisabled(Ellipse_7_0);
            NastavElipsuDisabled(Ellipse_7_1);
            NastavElipsuDisabled(Ellipse_7_2);
            NastavElipsuDisabled(Ellipse_7_3);

            NastavElipsuDisabled(Ellipse_8_0);
            NastavElipsuDisabled(Ellipse_8_1);
            NastavElipsuDisabled(Ellipse_8_2);
            NastavElipsuDisabled(Ellipse_8_3);
        }

        private void NastavBarvyPC()
        {
            barva1 = ZiskejBarvu();
            barva2 = ZiskejBarvu();
            barva3 = ZiskejBarvu();
            barva4 = ZiskejBarvu();
        }

        private Brush ZiskejBarvu()
        {
        Random random = new Random();
        int cislo = random.Next(1, 7);

            if (cislo == 1)
            {
                return  Brushes.Red;
            }
            else if (cislo == 2)
            {
                return Brushes.Green;
            }
            else if (cislo == 3)
            {
                return Brushes.Blue;
            }
            else if (cislo == 4)
            {
                return Brushes.Yellow;
            }
            else if (cislo == 5)
            {
                return Brushes.Orange;
            }
            else if (cislo == 6)
            {
                return Brushes.Purple;
            }
            return Brushes.Red;
        }

        private void BtnVyhodnotit_Click(object sender, RoutedEventArgs e)
        {
            Rectangle_0_0.Fill = Brushes.Gray;
            Rectangle_0_1.Fill = Brushes.Gray;
            Rectangle_0_2.Fill = Brushes.Gray;
            Rectangle_0_3.Fill = Brushes.Gray;
            //1. varianta
            int PocetCernych = 0;
            if (Ellipse_0_0.Fill == barva1)
            {
                PocetCernych++;
            }
            if (Ellipse_0_1.Fill == barva2)
            {
                PocetCernych++;
            }
            if (Ellipse_0_2.Fill == barva3)
            {
                PocetCernych++;
            }
            if (Ellipse_0_3.Fill == barva4)
            {
                PocetCernych++;
            }
            if (PocetCernych > 0)
            {
                Rectangle_0_0.Fill = Brushes.Black;
            }
            if (PocetCernych > 1)
            {
                Rectangle_0_1.Fill = Brushes.Black;
            }
            if (PocetCernych > 2)
            {
                Rectangle_0_2.Fill = Brushes.Black;
            }
            if (PocetCernych > 3)
            {
                Rectangle_0_3.Fill = Brushes.Black;
                MessageBox.Show("VYHRÁL JSI!");
            }
        }

        private void BtnNovaHra_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}


