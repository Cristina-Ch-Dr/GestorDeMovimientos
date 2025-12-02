using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMovimientos.Configuration {
    public class ConfigModel {
        // Guarda la cadena de conexión a la base de datos.
        public string ConnectionString { get; set; }
        // Almacena las consultas SQL.
        public Dictionary<string, string> Consultas { get; set; }
    }
}
