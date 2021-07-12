using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Pedido
    {
        [JsonProperty(propertyName: "id")]
        public string Id { get; set; }

        public int ClienteID { get; set; }

        public decimal Total { get; set; }

        public Item[] Items { get; set; }

        public Cliente Cliente { get; set; }

        public Endereco Endereco { get; set; }

        public bool Pago { get; set; }
    }
}
