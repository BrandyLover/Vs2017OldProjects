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

namespace Checker_de_Triângulo_APP
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            CalcButton.Click += CalcButton_Click;
        }

        

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            TriChecker myTriChecker = new TriChecker();
            myTriChecker.userInputa = aValue.Text;
            myTriChecker.userInputb = bValue.Text;
            myTriChecker.userInputc = cValue.Text;
            Resultadotbl.Text = TriChecker.Checker(myTriChecker.userInputa, myTriChecker.userInputb, myTriChecker.userInputc);
        }

       
    }
    class TriChecker
    {
        public string userInputa;
        public string userInputb;
        public string userInputc;

       public  static string Checker(string userInputa, string userInputb, string userInputc)
        {

            int a, b, c;
            if (Int32.TryParse(userInputa, out a)) ;
            else
            {

            }

            if (Int32.TryParse(userInputb, out b)) ;
            else
            {

            }


            if (Int32.TryParse(userInputc, out c)) ;

            else
            {

            }

            string TriIso = "Isóceles";
            string TriEqui = "Equilátero";
            string TriEsc = "Escaleno";
            string TriType = "";

            if (a == b & a == c)
            {
                TriType = TriEqui;

            }
            if (a == b & a != c | a == c & a != b | b == c & b != a)
            {
                TriType = TriIso;

            }
            if (a != b & a != c)
            {
                TriType = TriEsc;

            }
            string returnString = TriType;

            return returnString;

        }

    }
}
