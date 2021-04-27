using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marcas
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Marcas (string descripcion)
        {
            Descripcion = descripcion;
        }

        public Marcas (int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
