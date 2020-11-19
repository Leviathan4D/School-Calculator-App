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
    public partial class AreaCircleWindow : Window
    {
        public AreaCircleWindow()
        {
            InitializeComponent();
        }

        private void goAreaCircle_Click(object sender, RoutedEventArgs e)
        {
            double radius = double.Parse(radiusInputAreaCircle.Password);
            double area = 3.14 * Math.Pow(radius, 2);
            string message = area.ToString();
            MessageBox.Show(message);
        }
    }
}
