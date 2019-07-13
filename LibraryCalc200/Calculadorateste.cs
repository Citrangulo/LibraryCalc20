using LibraryCalc20;
using System;
using Xunit;

namespace LibraryCalc200
{
    public class Calculadorateste
    {
        [Fact]
        public void SomaSucesso()
        {
            var calculadora = new Calculadora();
            var a = 10;
            var b = 5;

            var resultado = calculadora.Soma(a, b);

            Assert.True((a + b) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 29)]
        [InlineData(-50, 32)]
        [InlineData(0, 2)]
        [InlineData(1, 200)]
        public void SomaError(int a, int b)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Soma(a, b);


            Assert.False((a + b) != resultado);
        }
        [Fact]
        public void SubSucesso()
        {
            var calculadora = new Calculadora();
            var a = 10;
            var b = 5;

            var resultado = calculadora.Sub(a, b);

            Assert.True((a - b) == resultado);
        }
        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 29)]
        [InlineData(-50, 32)]
        [InlineData(0, 2)]
        [InlineData(1, 200)]
        public void SubError(int a, int b)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Sub(a, b);


            Assert.False((a - b) != resultado);
        }

        [Fact]
        public void SomatresSucesso()
        {
            var calculadora = new Calculadora();
            var a = 10;
            var b = 5;
            var c = 6;

            var resultado = calculadora.Soma(a, b, c);

            Assert.True((a + b + c) == resultado);
        }

        [Theory]
        [InlineData(1, 2, 8)]
        [InlineData(10, 29, 10)]
        [InlineData(-50, 32, 79)]
        [InlineData(0, 2, -90)]
        [InlineData(1, 200, 99)]
        public void SomatresError(int a, int b, int c)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Soma(a, b, c);


            Assert.False((a + b + c) != resultado);
        }

        [Fact]
        public void DivSucesso()
        {
            var calculadora = new Calculadora();
            var a = 10;
            var b = 5;

            var resultado = calculadora.Div(a, b);

            Assert.True((a / b) == resultado);
        }
        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 29)]
        [InlineData(-50, 32)]
        [InlineData(0, 2)]
        [InlineData(1, 200)]
        public void DivError(int a, int b)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Div(a, b);


            Assert.False((a / b) != resultado);

        }
        [Fact]
        public void MultSucesso()
        {
            var calculadora = new Calculadora();
            var a = 10;
            var b = 5;

            var resultado = calculadora.Mult(a, b);

            Assert.True((a * b) == resultado);
        }
        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 29)]
        [InlineData(-50, 32)]
        [InlineData(0, 2)]
        [InlineData(1, 200)]
        public void MultError(int a, int b)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Mult(a, b);


            Assert.False((a * b) != resultado);
        }

        [Fact]
        public void SubtresSucesso()
        {
            var calculadora = new Calculadora();
            var a = 10;
            var b = 5;
            var c = 90;

            var resultado = calculadora.Sub(a, b, c);

            Assert.True((a - b - c) == resultado);
        }

        [Theory]
        [InlineData(1, 2, 5)]
        [InlineData(10, 29, 0)]
        [InlineData(-50, 32, 36)]
        [InlineData(0, 2, 17)]
        [InlineData(1, 200, 13)]
        public void SubtresError(int a, int b, int c)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Sub(a, b, c);


            Assert.False((a - b - c) != resultado);
        }

        [Fact]
        public void SomaEDivSucesso()
        {
            var calculadora = new Calculadora();
            var a = 10;
            var b = 4;
            var c = 7;

            var resultado = calculadora.Div(calculadora.Soma(a, b), c);

            Assert.True(((a + b)/c) == resultado);
        }
    }
}