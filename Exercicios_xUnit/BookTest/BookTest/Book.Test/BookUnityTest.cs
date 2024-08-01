using BookTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Test
{
    public class BookUnityTest
    {
        [Fact]
        public void AdicionarLivro()
        {

            var Title = "Mindset";
            var Gender = "Motivacional";
            var Pages = "500";

            var Quantity = 0;
            

            var add = AddBook.Adicionar(Title,Gender,Pages);

            Assert.NotEqual(add.Count,0);
        }
    }
}
