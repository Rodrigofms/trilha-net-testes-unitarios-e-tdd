using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Testes_Console.Models;

namespace Testes
{
    public class Novo_Teste
    {

        public Calculadora construirClasse()
        {
            Calculadora calc = new ("15/10/2023");
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(29, 38, 67)]
        public void TesteSoma(int val1, int val2, int resultado_esperado)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.somar(val1, val2);

            Assert.Equal(resultado_esperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(29, 38, 1102)]
        public void TesteMultiplicar(int val1, int val2, int resultado_esperado)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.multiplicar(val1, val2);

            Assert.Equal(resultado_esperado, resultado);
        }

        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(38, 29, 9)]
        public void TesteSubtrair(int val1, int val2, int resultado_esperado)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.subtrair(val1, val2);

            Assert.Equal(resultado_esperado, resultado);
        }

        [Fact]
        public void TesteDivisaoPor0()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = construirClasse();

            calc.somar(2,2);
            calc.somar(3,8);
            calc.somar(5,17);
            calc.somar(28,7);

            var lista = calc.hitorico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count());
        }
    }
}