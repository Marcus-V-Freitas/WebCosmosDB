using BLL.Models;
using DAL.Context;
using DAL.Interface;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AzureContext _azure;
        public PedidoRepository(AzureContext azure)
        {
            _azure = azure;
        }

        public async Task<Pedido> GetPedido(string id, int ClienteId)
        {
            var resultado = await _azure.container.ReadItemAsync<Pedido>(id, new PartitionKey(ClienteId));
            return resultado.StatusCode == HttpStatusCode.OK ? resultado.Resource : null;
        }

        public Task<IEnumerable<Pedido>> GetPedidos()
        {
            throw new NotImplementedException();
        }
    }
}
