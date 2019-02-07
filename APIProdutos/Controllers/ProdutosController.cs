using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIProdutos.Models;
using APIProdutos.Repository;

namespace APIProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return ProdutosRepository.Listar();
        }
    }
}