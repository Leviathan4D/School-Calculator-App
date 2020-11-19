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
    public partial class AreaSphereWindow : Window
    {
        public AreaSphereWindow()
        {
            InitializeComponent();
        }

        private void goAreaSphere_Click(object sender, RoutedEventArgs e)
        {
            double radius = double.Parse(inputAreaSphere.Password);
            double powerRadius = Math.Pow(radius, 3);
            double volume = 1.33 * 3.14 * powerRadius;
            string message = volume.ToString();
            MessageBox.Show(message);
        }
    }
}
