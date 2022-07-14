using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API_Controle_Estoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ILogger<ProdutosController> _logger;

        public ProdutosController(ILogger<ProdutosController> logger)
        {
            _logger = logger;
        }

        public static List<ProdutosModel> PRODUTOS = new();


        [HttpGet]
        [SwaggerOperation(Summary = "Recupera uma lista de produtos")]
        public async Task<ActionResult> Get()
        {
            return Ok(PRODUTOS);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Inseri um produto")]
        public async Task<ActionResult> Post(ProdutosModel produto)
        {
            PRODUTOS.Add(produto);
            return Ok(PRODUTOS);
        }
    }
}
