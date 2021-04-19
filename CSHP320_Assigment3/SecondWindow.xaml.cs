using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using CSHP320_Assigment3.Models;

namespace CSHP320_Assigment3
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        List<User> users = new List<User>();
        
        private bool NameSortAscending = true;
        private bool PwdSortAscending = true;

        public SecondWindow()
        {
            InitializeComponent();
            
            users.Add(new User { Name = "Dave", Password = "1DavePwd" });
            users.Add(new User { Name = "Steve", Password = "2StevePwd" });
            users.Add(new User { Name = "Lisa", Password = "3LisaPwd" });

            uxList.ItemsSource = users;

            uxList.AddHandler(GridViewColumnHeader.ClickEvent, new RoutedEventHandler(uxList_OnClick));
        }


        private void uxList_OnClick(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader headerClicked = e.OriginalSource as GridViewColumnHeader;

            uxList.ItemsSource = users; // Resets list on Click to allow for swapping between Name and Pass Column Sorting
            if (headerClicked.Column.Header.ToString() == "Name")
            {
                if (NameSortAscending)
                {
                    uxList.ItemsSource = users.OrderBy(x => x.Name);
                    NameSortAscending = false;
                }
                else
                {
                    uxList.ItemsSource = users.OrderByDescending(x => x.Name);
                    NameSortAscending = true;
                }
            }
            else if (headerClicked.Column.Header.ToString() == "Password")
            {
                if (PwdSortAscending)
                {
                    uxList.ItemsSource = users.OrderBy(x => x.Password);
                    PwdSortAscending = false;
                }
                else
                {
                    uxList.ItemsSource = users.OrderByDescending(x => x.Password);
                    PwdSortAscending = true;
                }
            }
        }
    }
}
