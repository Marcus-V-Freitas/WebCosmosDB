using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string CPFCNPJ { get; set; }

        public string Genero { get; set; }
    }
}
