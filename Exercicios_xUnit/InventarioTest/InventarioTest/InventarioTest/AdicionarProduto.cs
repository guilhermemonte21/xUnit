using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTest
{
    public class AdicionarProduto
    {
        public static Produto Adicionar(string nome, int Quantidade)
        {
            List<Produto> Lista = new List<Produto>
            {
                new Produto { Name = "PC", Quantity = 10 },
                new Produto { Name = "PS4", Quantity = 25 },
                new Produto { Name = "xbox", Quantity = 50 }
            };

            
            foreach (var item in Lista)
            {
                if (item.Name == nome)
                {
                    item.Quantity = item.Quantity + Quantidade;

                    return item;
                }
            }
            Produto newProduct = new Produto()
            {
                Name = nome,
                Quantity = Quantidade

            };

            Lista.Add(newProduct);

            return newProduct;
        }
        public static int Buscar(string nome, int quantidade)
        {
            List<Produto> Lista = new List<Produto>();
            foreach (var item in Lista)
            {
                return item.Quantity;

            }
            return 0;
        }
         
        

    }
}
