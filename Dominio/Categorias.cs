using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Categorias
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Categorias(string descripcion)
        {
            Descripcion = descripcion;
        }

        public Categorias(int id, string descripcion)
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
