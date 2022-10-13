using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCliente
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int IDCliente { get; set; }
        public string Cedula { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Departamento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}
