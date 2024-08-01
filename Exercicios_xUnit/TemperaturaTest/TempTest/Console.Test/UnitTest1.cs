using TempTest;

namespace Console.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Organizar
            var temp = 25;

            var valorEsperado = 77;


            //Agir
            var convert = Conversao.Converter(temp);


            //Provar
            Assert.Equal(valorEsperado, convert);
        }
    }
    }
