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
    class Program
    {
        #region private attributes
        static private int userInputOperand01;
        static private int userInputOperand02;
        static private int displayResult;
        #endregion private attributes

        /// <summary>
        /// This function is designed to be application's entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //ask user to input 2 operands
            Console.Write("First operand  : ");
            userInputOperand01 = int.Parse(Console.ReadLine());

            Console.Write("Second operand : ");
            userInputOperand02 = int.Parse(Console.ReadLine());

            //declare, init and use a "calculator" object
            Calculator calculator = new Calculator();
            displayResult = calculator.add(userInputOperand01, userInputOperand02);

            //display result
            Console.Write("Result of " + userInputOperand01 + " + " + userInputOperand02 + " = " + displayResult);
            Console.ReadLine();
        }
    }
}
