using APIxUnit.Domains;
using APIxUnit.Interface;
using APIxUnit.Repository;
using Microsoft.AspNetCore.SignalR;
using Moq;

namespace TesteApiUnit
{
    public class testApi
    {
        /// <summary>
        /// Teste para a funcionalidade de listar todos os produtos
        /// </summary>
        [Fact]
        public void Get()
        {
            //Arrange

            //Lista de produtos
            List<ProductsDomain> product = new List<ProductsDomain>
            {
                new ProductsDomain {IdProduct = Guid.NewGuid(),Name="Produto 1", Price= 78 },
                new ProductsDomain {IdProduct = Guid.NewGuid(),Name="Produto 2", Price= 90 },
                new ProductsDomain {IdProduct = Guid.NewGuid(),Name="Produto 3", Price= 178 }
            };
            //Cria um objeto de simulacao do tipo ProductRepository
            var mockRepository = new Mock<IProductsRepository>();

            //Configura o metodo "Get" para que quando for acionado retorne a lista "mockada"
            mockRepository.Setup(x => x.Get()).Returns(product);
            //Act

            //Executando o metodo "Get" e atribui a resposta em result
            var result = mockRepository.Object.Get();

            //Assert
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void Create()
        {
            //Arrange
            var products = new ProductsDomain()
            {
                IdProduct = Guid.NewGuid(),
                Name = "Produto 1",
                Price = 78
            };

            List<ProductsDomain> productList = new List<ProductsDomain>();

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Cadastrar(products)).Callback<ProductsDomain>(x => productList.Add(products));

            //Act
            mockRepository.Object.Cadastrar(products);


            //Assert
            Assert.Contains(products, productList);
        }
        [Fact]
        public void Delete()
        {
            var prp = new ProductsDomain { IdProduct = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"), Name = "produto1", Price = 10 };
            List<ProductsDomain> product = new List<ProductsDomain>
            {
                 prp,
                 new ProductsDomain {IdProduct = Guid.NewGuid(),Name="Produto 2", Price= 18 }
        };

            var mockRepository = new Mock<IProductsRepository>();



            mockRepository.Setup(x => x.Deletar(prp.IdProduct)).Callback(() => product.Remove(prp));

            mockRepository.Object.Deletar(prp.IdProduct);

            Assert.Equal(1, product.Count);




        }

        [Fact]
        public void GetById()
        {

            List<ProductsDomain> productList = new List<ProductsDomain>();


            ProductsDomain product = new ProductsDomain
            {
                IdProduct = Guid.NewGuid(),
                Name = "Anilha",
                Price = 10
            };

            productList.Add(product);


            var productBuscado = productList.FirstOrDefault(x => x.IdProduct == product.IdProduct);


            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.GetbyId(product.IdProduct)).Returns(productBuscado);

            mockRepository.Object.GetbyId(product.IdProduct);

            Assert.Equal(1, productList.Count);
        }

        /// <summary>
        /// Teste para a funcionalidade de atualizar um produto
        /// </summary>
        [Fact]
        public void Put()
        {

            List<ProductsDomain> productList = new List<ProductsDomain>();


            ProductsDomain product = new ProductsDomain
            {
                IdProduct = Guid.NewGuid(),
                Name = "Anilha",
                Price = 10
            };
            productList.Add(product);


            var mockRepository = new Mock<IProductsRepository>();


            mockRepository.Setup(x => x.Editar(product, product.IdProduct)).Callback<Guid, ProductsDomain>((id, p) =>
            {
                var item = productList.FirstOrDefault(x => x.IdProduct == id);

                if (item != null)
                {
                    p.Name = "Peso";
                    p.Price = 12;
                    productList.Add(product);
                }
            });

            mockRepository.Object.Editar(product, product.IdProduct);

            Assert.Equal("Peso", product.Name);
        }
    }
}