using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        public List<Cliente> PrintCliente()
        {
            return this.cliente;
        }

        public void SerializarCliente()
        {
            string ClienteJson = JsonConvert.SerializeObject(this.cliente.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, ClienteJson);
        }

        public void DeserealizarCliente()
        {
            if (File.Exists(_path))
            {
                string stringJson;
                using (var reader = new StreamReader(this._path))
                {
                    stringJson = reader.ReadToEnd();
                }

                var Datos = JsonConvert.DeserializeObject<List<Cliente>>(stringJson);
                this.cliente.AddRange(Datos);
            }
        }
    }
}
