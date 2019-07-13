# LibraryCalc20
Biblioteca de operações matemáticas

[![Build status](https://ci.appveyor.com/api/projects/status/7et2wx35ci0yfsy2/branch/master?svg=true)](https://ci.appveyor.com/project/Citrangulo/librarycalc20/branch/master)

![Nuget](https://img.shields.io/nuget/dt/LibraryCalc20.svg)

## How to install
Install-Package LibraryCalc20 -Version 1.0.3

## How to use

```cs

using LibraryCalc20;
using System;

namespace Financeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();
            var x = calculator.Soma(2, 30);
            Console.WriteLine("Value: " + x);
        }
    }
}
```
