using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula
{
    public class Curso
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Curso(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
