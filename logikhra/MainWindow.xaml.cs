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
            Random random = new Random();
            int cislo = random.Next(1, 7);

            if (cislo == 1)
            {
                barva1 = Brushes.Red;
            }
            else if (cislo == 2)
            {
                barva1 = Brushes.Green;
            }
            else if (cislo == 3)
            {
                barva1 = Brushes.Blue;
            }
            else if (cislo == 4)
            {
                barva1 = Brushes.Yellow;
            }
            else if (cislo == 5)
            {
                barva1 = Brushes.Orange;
            }
            else if (cislo == 6)
            {
                barva1 = Brushes.Purple;
            }

            if (cislo == 1)
            {
                barva2 = Brushes.Red;
            }
            else if (cislo == 2)
            {
                barva2 = Brushes.Green;
            }
            else if (cislo == 3)
            {
                barva2 = Brushes.Blue;
            }
            else if (cislo == 4)
            {
                barva2 = Brushes.Yellow;
            }
            else if (cislo == 5)
            {
                barva2 = Brushes.Orange;
            }
            else if (cislo == 6)
            {
                barva2 = Brushes.Purple;
            }

            if (cislo == 1)
            {
                barva3 = Brushes.Red;
            }
            else if (cislo == 2)
            {
                barva3 = Brushes.Green;
            }
            else if (cislo == 3)
            {
                barva3 = Brushes.Blue;
            }
            else if (cislo == 4)
            {
                barva3 = Brushes.Yellow;
            }
            else if (cislo == 5)
            {
                barva3 = Brushes.Orange;
            }
            else if (cislo == 6)
            {
                barva3 = Brushes.Purple;
            }

            if (cislo == 1)
            {
                barva4 = Brushes.Red;
            }
            else if (cislo == 2)
            {
                barva4 = Brushes.Green;
            }
            else if (cislo == 3)
            {
                barva4 = Brushes.Blue;
            }
            else if (cislo == 4)
            {
                barva4 = Brushes.Yellow;
            }
            else if (cislo == 5)
            {
                barva4 = Brushes.Orange;
            }
            else if (cislo == 6)
            {
                barva4 = Brushes.Purple;
            }
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
        
            }
    }


