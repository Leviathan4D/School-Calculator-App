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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton2.IsChecked == true) 
            { 
                CircumferenceCircleWindow win2 = new CircumferenceCircleWindow();
                win2.Show();
            } else if(radioButton1.IsChecked == true)
            {
                AreaSphereWindow win3 = new AreaSphereWindow();
                win3.Show();
            } else if(radioButton.IsChecked == true)
            {
                AreaConeWindow win4 = new AreaConeWindow();
                win4.Show();
            } else if(radioButton3.IsChecked == true)
            {
                SurfaceConeWindow win5 = new SurfaceConeWindow();
                win5.Show();
            } else if(radioButton4.IsChecked == true)
            {
                AreaCircleWindow win6 = new AreaCircleWindow();
                win6.Show();
            } else
            {
                MessageBox.Show("Error: Please Select an Equation");
            }
        }
    }
}
