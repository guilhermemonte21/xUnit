using InventarioTest;

namespace Console.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("cadeira", 2)]
        [InlineData("pote", 3)]
        [InlineData("controle",4)]

        public void Test1(string nome, int quantidade)
        {


            var esperado = 1;
            var add = AdicionarProduto.Adicionar(nome, quantidade);

            Assert.NotEqual(quantidade,esperado );
        }
    }
}