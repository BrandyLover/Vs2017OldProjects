using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
          // string myString = "My \"so-called\" life";
            /*      myString = "What if i need a \nnew line";
                  myString = "Go to your c:\\ drive";
              myString = @"Go to your c:\ drive";

                  myString = String.Format("{1} = {0}", "First", "Second");
              myString = string.Format("{0:C}", 123.45);
                  myString = string.Format( "{0:N}", 1234567890);
                  myString = string.Format("Percentage: {0:P}", .123);
             myString = string.Format("Phone Number: {0:(##)#####-####}", 53984155317);
             //myString = " That summer we took threes across the board  ";

            // myString = myString.Substring(6,14);
            // myString = myString.ToUpper();
            // myString = myString.Replace(" ", "--");

     myString = myString.Remove(6, 14);
     */
            /*
                    myString = String.Format("Lenght before: {0} -- Lenght after: {1}", myString.Length, myString.Trim().Length);

                    for (int i = 0; i < 100; i++)
                    {
                        myString += "--" + i.ToString();
                    }
                    */
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
