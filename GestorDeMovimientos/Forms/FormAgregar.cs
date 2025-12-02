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
    public partial class FormAgregar : Form {
        // Preparo el comboBox en el constructor con las opciones "Ingreso" y "Gasto".
        public FormAgregar() {
            InitializeComponent();

            comboBoxTipo.Items.Add("Ingreso");
            comboBoxTipo.Items.Add("Gasto");
            comboBoxTipo.SelectedIndex = 1; // Selecciona "Gasto"
        }
        // Evento del botón "Volver", simplemente cierra la ventana.
        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
        // Evento del botón "Guardar", crea un nuevo objeto Movimiento y lo guarda.
        private async void button1_Click(object sender, EventArgs e) {
            try {
                Movimiento nuevo = new() {
                    Tipo = comboBoxTipo.SelectedItem.ToString(), // "Ingreso" o "Gasto"
                    Importe = decimal.Parse(textBoxImporte.Text), // Convierte el texto a número decimal
                    Descripcion = textBoxDescripcion.Text
                };

                MovimientoRepository repo = new();
                await repo.InsertMovimiento(nuevo); // Inserta el movimiento en la base de datos

                MessageBox.Show("Movimiento agregado correctamente.");
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show("Error al agregar movimiento: " + ex.Message);
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e) {

        }
    }
}
