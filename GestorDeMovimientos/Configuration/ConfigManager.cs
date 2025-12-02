using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GestorDeMovimientos.Configuration {
    public class ConfigManager {

        private const string ConfigFileName = "configuracion.json";

        // Carga la configuración desde el archivo JSON o crea uno nuevo con valores predeterminados si no existe.
        public static ConfigModel LoadOrCreateDefault() {
            try {
                // Crearlo si necesario
                if (!File.Exists(ConfigFileName)) {
                    MessageBox.Show("Creando archivo de configuración por primera vez", "ConfigManager");

                    // Construir la cadena de conexión predeterminada
                    var builder = new Microsoft.Data.SqlClient.SqlConnectionStringBuilder {
                        DataSource = "localhost",
                        InitialCatalog = "GestorGastos",
                        IntegratedSecurity = true,
                        TrustServerCertificate = true
                    };
                    // Crear el modelo de configuración con consultas SQL predeterminadas
                    var config = new ConfigModel {
                        ConnectionString = builder.ToString(),
                        Consultas = new Dictionary<string, string>
                        {
                            { "SeleccionarTodos", "SELECT * FROM Movimientos ORDER BY Id DESC" },
                            { "UltimosMovimientos", "SELECT TOP 5 * FROM Movimientos ORDER BY Id DESC" },
                            { "Insertar", "INSERT INTO Movimientos (Tipo, Importe, Descripcion) VALUES (@tipo, @importe, @descripcion)" },
                            { "Eliminar", "DELETE FROM Movimientos WHERE Id = @Id" },
                            { "ModificarDescripcion", "UPDATE Movimientos SET Descripcion = @Descripcion WHERE Id = @Id" }
                        }
                    };
                    // Serializar y guardar en el archivo JSON
                    var options = new JsonSerializerOptions {
                        WriteIndented = true,
                        Converters = { new JsonStringEnumConverter() },
                        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                    };
                    
                    string json = JsonSerializer.Serialize(config, options);
                    File.WriteAllText(ConfigFileName, json);

                    return config;
                }
                // Cargar el archivo existente
                string existingJson = File.ReadAllText(ConfigFileName);
                return JsonSerializer.Deserialize<ConfigModel>(existingJson)!;

            } catch (Exception ex) {
                MessageBox.Show($"Error al cargar o crear configuración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
