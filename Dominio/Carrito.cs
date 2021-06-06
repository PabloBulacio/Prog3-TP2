using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Carrito
    {
        public DateTime Fecha { get; set; }
        public List<ItemCarrito> Items { get; set; }
    }
}
