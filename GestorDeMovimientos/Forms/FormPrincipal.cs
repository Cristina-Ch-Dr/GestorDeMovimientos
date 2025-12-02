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
    public partial class FormPrincipal : Form {
        private readonly MovimientoRepository _repo = new();

        // Inicializa y carga el load para configurar el DataGrid
        public FormPrincipal() {
            InitializeComponent();
            this.Load += FormPrincipal_Load;
        }
        // Carga el DataGrid al abrir el formulario y muestra los ultimos 5 los movimientos.
        private async void FormPrincipal_Load(object sender, EventArgs e) {
            DataGridHelper.ConfigurarColumnas(dataGridResumen);
            await LoadMovimientosAsync();
        }
        // Método auxiliar para cargar movimientos y establecer la fuente como el DataGrid.
        private async Task LoadMovimientosAsync() {
            var movimientos = await _repo.UltimosMovimientos();
            dataGridResumen.DataSource = movimientos;
        }
        // Evento del botón "Agregar", abre el formulario para agregar un nuevo movimiento.
        private void buttonAgregar_Click(object sender, EventArgs e) {
            FormAgregar pantallaAgregar = new FormAgregar();
            pantallaAgregar.ShowDialog();
        }
        // Evento del botón "Eliminar", abre el formulario para eliminar un movimiento.
        private void buttonEli_Click(object sender, EventArgs e) {
            FormEliminar pantallaEliminar = new FormEliminar();
            pantallaEliminar.ShowDialog();
        }
        // Evento del botón "Modificar", abre el formulario para modificar un movimiento.
        private void buttonModi_Click(object sender, EventArgs e) {
            FormModificar pantallaModificar = new FormModificar();
            pantallaModificar.ShowDialog();
        }
        // Evento del botón "Actualizar", actualiza los últimos movimientos en el DataGrid.
        private async void buttonAct_Click(object sender, EventArgs e) {
            await LoadMovimientosAsync();
        }
        // Evento del botón "Ver Todos", abre el formulario para mostrar todos los movimientos.
        private void buttonTodos_Click(object sender, EventArgs e) {
            FormMostrar pantallaMostrar = new FormMostrar();
            pantallaMostrar.ShowDialog();
        }

        private void FormPrincipal_Load_1(object sender, EventArgs e) {

        }
    }
}

