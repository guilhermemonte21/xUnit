using EmailTest;
using System.ComponentModel.DataAnnotations;

namespace Console.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("guilherme@gmail.com")]
        [InlineData("guilherme.monte.gmail.com")]
        [InlineData("guilherme@gmail")]
        public void Test1(string mail)
        {
            

            var ResultadoEsperado = true;

            var Mail = Email.Validar(mail);

            Assert.Equal(Mail, ResultadoEsperado);



        }
    }
}