using GestorDeMovimientos.Configuration;
using GestorDeMovimientos.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace GestorDeMovimientos.Repository {
    public class MovimientoRepository {
        private readonly string _connectionString;
        private readonly Dictionary<string, string> _consultas;

        public MovimientoRepository() {
            var config = ConfigManager.LoadOrCreateDefault();
            _connectionString = config.ConnectionString;
            _consultas = config.Consultas;
        }
        // Ejecuta la consulta "UltimosMovimientos" y devuelve una lista de objetos Movimiento.
        // Recojen los últimos 5 movimientos registrados.
        public async Task<List<Movimiento>> UltimosMovimientos() {
            List<Movimiento> movimientos = new();

            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = _consultas["UltimosMovimientos"]; 

            using SqlDataReader reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync()) {
                Movimiento m = new() {
                    Id = reader.GetInt32(0),
                    Tipo = reader.GetString(1),
                    Importe = reader.GetDecimal(2),
                    Descripcion = reader.GetString(3)
                };
                movimientos.Add(m);
            }

            return movimientos;
        }
        // Obtiene todos los movimientos de la base de datos.
        // Ejecuta la consulta "SeleccionarTodos" y devuelve la lista completa.
        public async Task<List<Movimiento>> TodosMovimientos() {
            List<Movimiento> movimientos = new();

            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = _consultas["SeleccionarTodos"];

            using SqlDataReader reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync()) {
                Movimiento m = new() {
                    Id = reader.GetInt32(0),
                    Tipo = reader.GetString(1),
                    Importe = reader.GetDecimal(2),
                    Descripcion = reader.GetString(3)
                };
                movimientos.Add(m);
            }

            return movimientos;
        }
        // Inserta un nuevo movimiento en la base de datos.
        // Uso parámetros para evitar inyecciones SQL.
        public async Task InsertMovimiento(Movimiento movimiento) {
            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = _consultas["Insertar"];

            command.Parameters.Add(new SqlParameter("@tipo", SqlDbType.NVarChar) { Value = movimiento.Tipo });
            command.Parameters.Add(new SqlParameter("@importe", SqlDbType.Money) { Value = movimiento.Importe });
            command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar) { Value = movimiento.Descripcion });

            await command.ExecuteNonQueryAsync();
        }
        // Elimina un movimiento por su Id.
        // Si no se encuentra ninguna fila afectada, lanza una excepción.
        public async Task EliminarMovimiento(int id) {
            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = _consultas["Eliminar"];
            command.Parameters.AddWithValue("@Id", id);

            int filasAfectadas = await command.ExecuteNonQueryAsync();

            if (filasAfectadas == 0) {
                throw new Exception($"No se encontró ningún movimiento con Id = {id}");
            }
        }
        // Modifica la descripción de un movimiento existente.
        // Si no se encuentra el movimiento, lanza una excepción.
        public async Task ModificarDescripcion(int id, string nuevaDescripcion) {
            using SqlConnection connection = new(_connectionString);
            await connection.OpenAsync();

            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = _consultas["ModificarDescripcion"];
            command.Parameters.AddWithValue("@Descripcion", nuevaDescripcion);
            command.Parameters.AddWithValue("@Id", id);

            int filas = await command.ExecuteNonQueryAsync();

            if (filas == 0) {
                throw new Exception("No se encontró el movimiento a modificar.");
            }
        }
    }
}