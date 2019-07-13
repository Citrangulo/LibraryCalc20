using System;
using System.Collections.Generic;
using System.Text;
// Para implementar a interface, tem que por o interface. Ou não compila.
 
namespace LibraryCalc20
{
    public interface ICalculadora
    {
         int Soma(int a, int b);
        /// <summary>
        /// Soma de valores
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Resultado da soma</returns>

         int Sub(int a, int b);
        /// <summary>
        /// Sub de valores
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Resultado da Sub</returns>

         int Div(int a, int b);
        /// <summary>
        /// Div de valores
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Resultado da Div</returns>

         int Mult(int a, int b);
        /// <summary>
        /// Mult de valores
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Resultado da Mult</returns>

        int Soma(int a, int b, int c);
        /// <summary>
        /// Soma de valores
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Resultado da soma</returns>
    }
}
