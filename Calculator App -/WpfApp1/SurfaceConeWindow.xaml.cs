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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SurfaceConeWindow : Window
    {
        public SurfaceConeWindow()
        {
            InitializeComponent();
        }

        private void goSurfaceCone_Click(object sender, RoutedEventArgs e)
        {
            double radius = double.Parse(radiusInputSurfaceCone.Password);
            double height = double.Parse(heightInputSurfaceCone.Password);
            double surface = 3.14 * radius*(radius + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius, 2)));
            string message = surface.ToString();
            MessageBox.Show(message);
        }
    }
}
