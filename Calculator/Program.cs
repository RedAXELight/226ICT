/*  Title  :    Calculator
 *  Author :    nicolas.glassey@cpnv.ch
 *  Version:    06.09.2018 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    public class Program
    {
        #region private attributes
        static private int userInputOperand01;
        static private int userInputOperand02;
        static private int displayResult;
        private static int displayResult2;
        private static int displayResult3;
        private static int displayResult4;
        private static char choose = ' ';
        #endregion private attributes

        /// <summary>
        /// This function is designed to be application's entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ask user to input 2 operands


            //gestion du premier nombre entré
            #region firstOperand
            Console.Write("First operand  : ");
            #region test of the entry 1
            try
            {
                bool right1 = int.TryParse(Console.ReadLine(), out userInputOperand01);
                if (!right1)
                {
                    do
                    {
                        Console.Write("Illegal character detected, try again: ");
                        right1 = int.TryParse(Console.ReadLine(), out userInputOperand01);
                    } while (!right1);
                }
            }
            catch (System.FormatException ex)
            {
                Console.Write("Error " + ex.ToString());
            }
            #endregion
            #endregion


            #region secondOperand
            Console.Write("Second operand : ");     
            #region test of the entry 2
            try
            {
                bool right2 = int.TryParse(Console.ReadLine(), out userInputOperand02);
                if (!right2)
                {
                    do
                    {
                        Console.Write("Illegal character detected, try again: ");
                        right2 = int.TryParse(Console.ReadLine(), out userInputOperand02);
                    } while (!right2);
                }
            }
            catch (System.FormatException ex)
            {
                Console.Write("Error " + ex.ToString());
            }
            #endregion
            #endregion




            #region Choose sign
            // clear the board
            Console.Clear();
            Console.Write("Which is the desired operation? \n");
            Console.Write(" + (addition)\n");
            Console.Write(" - (substitution)\n");
            Console.Write(" / (dividing)\n");
            Console.Write(" * (multiplication)\n ");
            choose = (char)Console.Read();
            #endregion

            //Display of the result
            Console.Clear();
            Calculator calc = new Calculator();
            calc.
            Calculator.operations(choose); //Putting in parameter the content of variable "choose"
            Console.ReadLine();



        }
    }
}
