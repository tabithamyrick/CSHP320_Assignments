﻿using System;
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

namespace CSHP320_InventoryManagementProject
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
    }
}

//You must design a SQL database application that is to keep track of items (pets, medicine, inventory, etc). You may use any standard C# programming language feature to complete the project.

//You can chose any kind of project but it must have the ability to add, change, delete, and display items in a database. It could be an album tracker, pet tracker, event calendar, medicine tracker, etc.

//You will NEED to submit a YouTube video of your project exercising it's capabilities. Please limit it to 4 minutes or less. Talk about the WPF features (menus, ListView, database, etc), any difficulties, and anything you would do differently.

//The program must have a menu to be able to complete the following tasks:

//Add an item
//Change an item (by giving its item number not an array index)
//Delete an item (by giving its item number not an array index)
//List all items in the database
//Quit
//Additional requirements:

//You should validate that the required fields are entered. You should not allow Add/Update if fields are missing.
//You should have a status bar that shows the number of records in the view.
//You should have search functionality. You should be able to search on a single field and have the list display only those records.
//If you use dates, you should use the DatePicker control.
//An example inventory item would have the following information associated with it:

//Item # (int)
//Description
//Price per item (double)
//Quantity on hand (int)
//Our cost per item (double)
//Value of item (calculated: price* quantity on hand)
