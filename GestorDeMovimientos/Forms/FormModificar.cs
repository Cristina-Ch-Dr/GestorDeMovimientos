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
    public partial class FormModificar : Form {
        // Acceder a los movimientos guardados para modificarlos
        private readonly MovimientoRepository _repo = new();

        // Inicializa y carga el load para configurar el DataGrid
        public FormModificar() {
            InitializeComponent();
            this.Load += FormModificar_Load;
        }
        // Carga el DataGrid al abrir el formulario y muestra todos los movimientos.
        private async void FormModificar_Load(object sender, EventArgs e) {
            DataGridHelper.ConfigurarColumnas(dataGridTodos); // Configura las columnas del grid
            dataGridTodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selección de fila completa
            dataGridTodos.MultiSelect = false; // Solo se puede seleccionar una fila
            dataGridTodos.SelectionChanged += dataGridTodos_SelectionChanged; // Conecta el evento de selección
            await CargarMovimientosAsync();
        }
        // Método auxiliar para cargar movimientos y establecer la fuente como el DataGrid.
        private async Task CargarMovimientosAsync() {
            var movimientos = await _repo.TodosMovimientos();
            dataGridTodos.DataSource = movimientos;
        }
        // Si hay una fila seleccionada, muestra la descripción del movimiento en el TextBox.
        private void dataGridTodos_SelectionChanged(object sender, EventArgs e) {
            if (dataGridTodos.SelectedRows.Count > 0) {
                var fila = dataGridTodos.SelectedRows[0];
                if (fila.DataBoundItem is Movimiento movimiento) {
                    textBoxDescripcion.Text = movimiento.Descripcion; 
                }
            }
        }
        // Evento del botón "Volver", simplemente cierra la ventana.
        private void buttonVolver_Click(object sender, EventArgs e) {
            this.Close();
        }
        // Evento del botón "Modificar", comprueba la selección y modifica la descripción del movimiento seleccionado.
        private async void buttonModi_Click(object sender, EventArgs e) {
            // Comprobar si hay una fila seleccionada.
            if (dataGridTodos.SelectedRows.Count == 0) {
                MessageBox.Show("Selecciona un movimiento para modificar.");
                return;
            }
            // Obtener la nueva descripción del TextBox.
            string nuevaDescripcion = textBoxDescripcion.Text.Trim();
            // Validar que la descripción no esté vacía.
            if (string.IsNullOrWhiteSpace(nuevaDescripcion)) {
                MessageBox.Show("La nueva descripción no puede estar vacía.");
                return;
            }
            // Obtener el movimiento de la fila seleccionada e intentar modificarlo.
            var fila = dataGridTodos.SelectedRows[0];
            if (fila.DataBoundItem is Movimiento movimiento) {
                try {
                    await _repo.ModificarDescripcion(movimiento.Id, nuevaDescripcion);
                    MessageBox.Show("Descripción modificada correctamente.");
                    textBoxDescripcion.Clear();
                    await CargarMovimientosAsync();
                } catch (Exception ex) {
                    MessageBox.Show($"Error al modificar: {ex.Message}");
                }
            }
        }
    }
}
