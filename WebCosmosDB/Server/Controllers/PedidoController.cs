using DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCosmosDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private IPedidoRepository _pedido;

        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedido = pedidoRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPedido([FromRoute] string id)
        {
            var pedido = await _pedido.GetPedido(id, 1);

            if (pedido is null)
                return BadRequest("Não há dados");

            return Ok(pedido);
        }
    }
}
