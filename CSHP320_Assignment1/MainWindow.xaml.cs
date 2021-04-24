// Myrick, Thaddaeus CSHP 320 Homework 1

using System.Windows;
using System.Windows.Controls;


namespace HelloWorld
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
        // Private fields to pass the input data

        private string uxname;
        private string uxpass;

        // ux inputs field set and check for enable submit
        private void ux_TargetUpdated(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Name == "uxName")
            {
                uxname = tb.Text;
            }
            else if (tb.Name == "uxPassword")
            {
                uxpass = tb.Text;
            }
            enableSubmitBtn();
        }

        // Enable submit button method

        private void enableSubmitBtn()
        {
            uxSubmit.IsEnabled = ((uxpass != null && uxpass != "") && (uxname != null && uxname != ""));
        }

        // submit button action

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting Password: " + uxPassword.Text);
        }


    }
}
