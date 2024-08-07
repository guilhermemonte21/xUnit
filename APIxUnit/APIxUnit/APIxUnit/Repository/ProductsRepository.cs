using APIxUnit.Domains;
using APIxUnit.Interface;
using APIxUnit.Context;
using Microsoft.EntityFrameworkCore;

namespace APIxUnit.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private XContext _context = new XContext();
        public void Cadastrar(ProductsDomain products)
        {
            //Adiciona o produto
            _context.Products.Add(products);
            //Salva as mudancas
            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {

            ProductsDomain products = _context.Products.FirstOrDefault(x => x.IdProduct == id)!;

            _context.Products.Remove(products);

            _context.SaveChanges();
        }

        public void Editar(ProductsDomain products, Guid id)
        {
            try
            {
                ProductsDomain p = _context.Products.Find(id)!;
                if (p != null)
                {
                    p.Name = products.Name;
                    p.Price = products.Price;
                }
                _context.Products.Update(p!);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
            public List<ProductsDomain> Get()
        {
            

            return _context.Products.ToList();

        }

        public ProductsDomain GetbyId(Guid id)
        {
            //busca a ong pelo ID
            ProductsDomain products = _context.Products.FirstOrDefault(c => c.IdProduct == id)!;



            return products;
        }
    }
}

