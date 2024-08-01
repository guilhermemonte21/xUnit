using InventarioTest;

namespace Console.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var Nome = "Cadeira";
            var Quantidade = 2;


            var add = AdicionarProduto.Adicionar(Nome, Quantidade);

            Assert.Equal(Quantidade, 2);
        }
    }
}