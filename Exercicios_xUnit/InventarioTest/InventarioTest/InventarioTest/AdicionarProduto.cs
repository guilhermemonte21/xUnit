using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTest
{
    public class AdicionarProduto
    {
        public static List<Object> Adicionar(string nome, double Quantidade)
        {
            var Lista = new List<Object>();

            var newProduct = new
            {
                nome = nome,
                Quantity = Quantidade

            };
            if (nome == nome)
            {
                Quantidade++;
            }

            Lista.Add(newProduct);

            return Lista;
        }

    }
}
