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
        public MainWindow()
        {
            InitializeComponent();
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
    }
}

