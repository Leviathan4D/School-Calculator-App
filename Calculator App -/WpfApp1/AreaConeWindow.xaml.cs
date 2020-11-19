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
    public partial class AreaConeWindow : Window
    {
        public AreaConeWindow()
        {
            InitializeComponent();
        }

        private void goAreaCone_Click(object sender, RoutedEventArgs e)
        {
            double radius = double.Parse(radiusInputAreaCone.Password);
            double height = double.Parse(heightInputAreaCone.Password);
            double powerRadius = Math.Pow(radius, 2);
            double heightDivided = height / 3;
            double volume = 3.14 * powerRadius * heightDivided;
            string message = volume.ToString();
            MessageBox.Show(message);
        }
    }
}
