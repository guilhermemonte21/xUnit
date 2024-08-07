using APIxUnit.Domains;
using APIxUnit.Interface;
using APIxUnit.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIxUnit.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private IProductsRepository productsRepository { get; set; }

        public ProductController()
        {
            productsRepository = new ProductsRepository();
        }

        [HttpPost("Cadastrar")]
        public async Task<IActionResult> Post(ProductsDomain products)
        {
            try
            {
                
                ProductsDomain newProduct = new()
                {
                    Name = products.Name,
                    Price = products.Price,
                   
                };

                

                
                productsRepository.Cadastrar(newProduct);
                

                return Ok($"cadastrada com sucesso!");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet("Listar")]
        public IActionResult Get()
        {
            try
            {
                return Ok(productsRepository.Get());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                productsRepository.Deletar(id);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet("BuscarPorId")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(productsRepository.GetbyId(id));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Editar")]
        public IActionResult Put(ProductsDomain products, Guid id)
        {
            try
            {
                productsRepository.Editar(products, id);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
