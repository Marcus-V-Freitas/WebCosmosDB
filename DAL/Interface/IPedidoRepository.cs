using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<Pedido>> GetPedidos();

        Task<Pedido> GetPedido(string id, int ClienteId);
    }
}
