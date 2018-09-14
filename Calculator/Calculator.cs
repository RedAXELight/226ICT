using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    public class Calculator
    {
        #region public methods
        public int Calc(int operand1, int operand2, char operat)
        {
            #region switch for results dipsplay
            {
                int result = 0;
                //Dynamical display of the results is made here
                switch (operat)
                {
                    case '+':                
                        result = Add(operand1, operand2);
                        break;
                    case '-':
                        break;
                    case '/':
                        break;
                    case '*':
                        break;
                    default:
                        //TODO
                        break;
                }
                return result;
            }
            #endregion

        }
        #endregion public methods

        #region private methods
        private int Add(int op1, int op2)
        {
            return op1 + op2;
        }
        #endregion private methods

    }




}
