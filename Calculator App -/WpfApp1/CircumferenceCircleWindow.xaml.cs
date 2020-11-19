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
    public partial class CircumferenceCircleWindow : Window
    {
        public CircumferenceCircleWindow()
        {
            InitializeComponent();
        }

        private void goCircumferenceCircle_Click(object sender, RoutedEventArgs e)
        {
            double radius = double.Parse(inputBoxCircumferenceCircle.Password);
            double diameter = radius * 2;
            double circumference = diameter*3.14;
            string message = circumference.ToString();
            MessageBox.Show(message);
        }
    }
}
