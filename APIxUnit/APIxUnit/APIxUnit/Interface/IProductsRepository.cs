using APIxUnit.Domains;

namespace APIxUnit.Interface
{
    public interface IProductsRepository
    {
        public void Cadastrar(ProductsDomain products);

        public void Deletar(Guid id);
        public void Editar(ProductsDomain products, Guid id);

        public List<ProductsDomain> Get();

        public ProductsDomain GetbyId(Guid id);
    }
}
