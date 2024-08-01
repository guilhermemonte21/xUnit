
using ConsoleTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Test
{
    public class ConsoleUnitTestz
    {
        //Principio AAA: Act, Arrange e Assert
        //Principio AAA: Agir, Organizar e Provar

        [Fact]
        public void SomarDoisNumeros()
        {
            //Organizar
            var n1 = 3.3;
            var n2 = 2.7;

            var valorEsperado = 6;

            //Agir
            var soma = Calculo.Somar(n1, n2);

            //Provar
            Assert.Equal(valorEsperado,soma);
        }
    }
}
