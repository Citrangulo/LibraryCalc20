using System;
using LibraryCalc20;

namespace LibraryCalc20
{
    public class Calculadora : ICalculadora
    {

        public Calculadora() { }
        public int  Soma(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int Soma(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }

        public int SomaEDiv(int a, int b, int c)
        {
            return (a + b) / c;
        }
    }
}
