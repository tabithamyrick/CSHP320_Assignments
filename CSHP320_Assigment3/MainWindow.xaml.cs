// Myrick, Thaddaeus CSHP 320 Homework 1

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

namespace CSHP320_Assigment3
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

        private string uxname;
        private string uxpass;
        

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting Password: "+ uxPassword.Text);

            var window = new SecondWindow();
            Application.Current.MainWindow = window;
            Close();
            window.Show();
        }


        private void uxSubmit_TargetUpdated(object sender, RoutedEventArgs e)
        {
            if (uxPassword.Text.Length > 0 && uxName.Text.Length > 0)
            {
                uxSubmit.IsEnabled = true;
            }
        }

        private void uxName_TargetUpdated(object sender, RoutedEventArgs e)
        {
            uxname = uxName.Text;
            enableSubmitBtn();
        }

        private void uxPassword_TargetUpdated(object sender, RoutedEventArgs e)
        {
            uxpass = uxPassword.Text;
            enableSubmitBtn();
        }

        private void enableSubmitBtn()
        {
               uxSubmit.IsEnabled = ((uxpass != null && uxpass != "") && (uxname != null && uxname != ""));
        }

    }
}
