using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Text.Json;

namespace DataCliente
{
    public class FileDB
    {
        List<Cliente> cliente = new List<Cliente>();
        public string _path = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Clientes.json";
        public void AddCliente(Cliente cliente)
        {
            this.cliente.Add(cliente);
        }
        public List<Cliente> PrintProduct()
        {
            return this.cliente;
        }

        //public void UpdateCliente(int index, int ID, string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, string Correo,
        //    string Departamento, string Direccion, string Telefono)
        //{
        //    this.cliente[index].IDCliente = ID;
        //    this.cliente[index].PrimerNombre = PrimerNombre;
        //    this.cliente[index].SegundoNombre = SegundoNombre;
        //    this.cliente[index].PrimerApellido = PrimerApellido;
        //    this.cliente[index].SegundoApellido = SegundoApellido;
        //    this.cliente[index].Correo = Correo;
        //    this.cliente[index].Departamento = Departamento;
        //    this.cliente[index].Direccion = Direccion;
        //    this.cliente[index].Telefono = Telefono;
        //}

        public void SerializerJSON()
        {
            string clienteJSON = JsonConverter.SerializeObject(this.Clientes.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, clienteJson);
        }
    }
}
