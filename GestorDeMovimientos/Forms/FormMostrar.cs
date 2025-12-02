using GestorDeMovimientos.Helpers;
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
    public partial class FormMostrar : Form {
        // Acceder a los movimientos guardados para modificarlos
        private readonly MovimientoRepository _repo = new();

        // Inicializa y carga el load para configurar el DataGrid
        public FormMostrar() {
            InitializeComponent();
            this.Load += FormFiltrar_Load;
        }
        // Carga el DataGrid al abrir el formulario y muestra todos los movimientos.
        private async void FormFiltrar_Load(object sender, EventArgs e) {
            DataGridHelper.ConfigurarColumnas(dataGridTodo);
            comboBoxTipo.Items.AddRange(new[] { "Todos", "Ingreso", "Gasto" }); // Opciones de filtro
            comboBoxTipo.SelectedIndex = 0; // Selecciona "Todos" por defecto
            await CargarMovimientosAsync();
        }
        // Método auxiliar para cargar movimientos y establecer la fuente como el DataGrid.
        private async Task CargarMovimientosAsync(string tipo = "Todos") {
            var movimientos = await _repo.TodosMovimientos();

            if (tipo != "Todos") {
                movimientos = movimientos.Where(m => m.Tipo == tipo).ToList(); // Filtra por tipo
            }
            dataGridTodo.DataSource = movimientos;
        }
        // Evento del botón "Volver", simplemente cierra la ventana.
        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
        // Evento del botón "Filtrar", carga los movimientos según el tipo seleccionado.
        private async void buttonFiltrar_Click(object sender, EventArgs e) {
            string tipoSeleccionado = comboBoxTipo.SelectedItem?.ToString() ?? "Todos";
            await CargarMovimientosAsync(tipoSeleccionado);
        }

        private void FormMostrar_Load(object sender, EventArgs e) {

        }
    }
}
