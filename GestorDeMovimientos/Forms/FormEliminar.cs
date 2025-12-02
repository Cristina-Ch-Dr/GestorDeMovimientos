using GestorDeMovimientos.Helpers;
using GestorDeMovimientos.Models;
using GestorDeMovimientos.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeMovimientos.Forms {
    public partial class FormEliminar : Form {
        // Acceder a los movimientos guardados.
        private readonly MovimientoRepository _repo = new();

        // Inicializa y carga el load para configurar el DataGrid
        public FormEliminar() {
            InitializeComponent();
            this.Load += FormEliminar_Load;
        }
        // Evento del botón "Volver", simplemente cierra la ventana.
        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
        // Carga el DataGrid al abrir el formulario y muestra todos los movimientos.
        private async void FormEliminar_Load(object sender, EventArgs e) {
            DataGridHelper.ConfigurarColumnas(dataGridTodos);
            dataGridTodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTodos.MultiSelect = false;
            await CargarMovimientosAsync();
        }
        // Método auxiliar para cargar movimientos y establecer la fuente como el DataGrid.
        private async Task CargarMovimientosAsync() {
            var movimientos = await _repo.TodosMovimientos();
            dataGridTodos.DataSource = movimientos;
        }
        // Evento del botón "Eliminar", comprueba la selección y elimina el movimiento seleccionado con confirmación.
        private async void buttonEli_Click(object sender, EventArgs e) {
            // Comprobar si hay una fila seleccionada.
            if (dataGridTodos.SelectedRows.Count == 0) {
                MessageBox.Show("Selecciona una fila para eliminar.");
                return;
            }
            // Obtener el movimiento de la fila seleccionada.
            var fila = dataGridTodos.SelectedRows[0];
            if (fila.DataBoundItem is Movimiento movimiento) {
                var confirmacion = MessageBox.Show(
                    $"¿Seguro que quieres eliminar el movimiento de \"{movimiento.Descripcion}\"?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                // Si el usuario confirma, eliminar el movimiento.
                if (confirmacion == DialogResult.Yes) {
                    try {
                        await _repo.EliminarMovimiento(movimiento.Id);
                        MessageBox.Show("Movimiento eliminado correctamente.");
                        await CargarMovimientosAsync();
                    } catch (Exception ex) {
                        MessageBox.Show($"Error al eliminar: {ex.Message}");
                    }
                }
            }
        }
    }
}
