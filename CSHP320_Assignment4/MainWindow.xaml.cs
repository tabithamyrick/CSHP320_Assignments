using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CSHP320_Assignment4
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

      
        private void ZipSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zip Code is: " + ZipCode.Text);
        }

        private void ZipCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            ZipSubmit.IsEnabled = (Regex.Match(ZipCode.Text, @"^\d{5}(?:[-\s]\d{4})?$|^[A-Z]{1}\d{1}[A-Z]{1}\d{1}[A-Z]{1}\d{1}$").Success);
        }
    }
}
