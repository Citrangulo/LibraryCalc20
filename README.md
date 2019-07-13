# LibraryCalc20
Biblioteca de operações matemáticas

[![Build status](https://ci.appveyor.com/api/projects/status/7et2wx35ci0yfsy2/branch/master?svg=true)](https://ci.appveyor.com/project/Citrangulo/librarycalc20/branch/master)

![Nuget](https://img.shields.io/nuget/dt/LibraryCalc20.svg)

## How to install
Install-Package LibraryCalc20 -Version 1.0.3

## How to use

```cs

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
```
