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

namespace CSHP320_Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxTurn.Text = "X's Turn";
        }

        
        private string turn = "X";
        Dictionary<string, string> ScoreDictionary = new Dictionary<string, string>();
        

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Content == null && !uxTurn.Text.Contains("Wins"))
            {
                btn.Content = turn;
                CheckForWinner(btn);
            }
            else
            {
                uxNewGame_Click(sender, e);
            }
        }

        private void CheckForWinner(Button btn)
        {
            List<string> xList = new List<string>();
            ScoreDictionary.Add(btn.Tag.ToString(), btn.Content.ToString());
            var checkArray = ScoreDictionary.Where(x => x.Value == turn).OrderBy(x => x.Key).Select(x => x.Key).ToArray();
            if(checkArray.Length >= 3)
            {
                if((checkArray.Contains("0,0") & checkArray.Contains("0,1") & checkArray.Contains("0,2")) || 
                    (checkArray.Contains("1,0") & checkArray.Contains("1,1") & checkArray.Contains("1,2")) ||
                    (checkArray.Contains("2,0") & checkArray.Contains("2,1") & checkArray.Contains("2,2")) ||
                    (checkArray.Contains("0,0") & checkArray.Contains("1,1") & checkArray.Contains("2,2")) ||
                    (checkArray.Contains("2,0") & checkArray.Contains("1,1") & checkArray.Contains("0,2")) ||
                    (checkArray.Contains("0,0") & checkArray.Contains("1,0") & checkArray.Contains("2,0")) ||
                    (checkArray.Contains("0,1") & checkArray.Contains("1,1") & checkArray.Contains("2,1")) ||
                    (checkArray.Contains("0,2") & checkArray.Contains("1,2") & checkArray.Contains("2,2")))
                {
                    uxTurn.Text = turn.ToString() + " Wins";
                }
                else
                {
                    SwapTurns(btn);
                }
            }
            else if(checkArray.Length == 5)
            {
                uxTurn.Text = "CAT";
                ClearBoard();
            }
            else
            {
                SwapTurns(btn);
            }
        }

        private void SwapTurns(Button btn)
        {
            if(turn == "X")
            {
                uxTurn.Text = "O's Turn";
                turn = "O";
            }
            else
            {
                uxTurn.Text = "X's Turn";
                turn = "X";
            }
        }


        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            uxTurn.Text = "X's Turn";
            turn = "X";
            ScoreDictionary.Clear();
            ClearBoard();
        }

        private void ClearBoard()
        {
            foreach (UIElement child in uxGrid.Children)
            {
                Button btn = (Button)child;
                btn.Content = null;
            }
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
