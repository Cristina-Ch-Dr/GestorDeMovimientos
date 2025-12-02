using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMovimientos.Helpers {
    public static class DataGridHelper {
        // Función auxiliar para organizar todos los DataGrid de la misma forma.
        public static void ConfigurarColumnas(DataGridView grid) {
            grid.Columns.Clear();

            // Columna Id (oculta)
            var colId = new DataGridViewTextBoxColumn {
                Name = "Id",
                DataPropertyName = "Id",
                Visible = false
            };

            // Columna Tipo
            var colTipo = new DataGridViewTextBoxColumn {
                Name = "Tipo",
                HeaderText = "Tipo",
                DataPropertyName = "Tipo",
                Width = 80
            };

            // Columna Importe
            var colImporte = new DataGridViewTextBoxColumn {
                Name = "Importe",
                HeaderText = "Importe (€)",
                DataPropertyName = "Importe",
                Width = 100,
                ValueType = typeof(decimal),
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // Formato moneda
            };

            // Columna Descripción
            var colDescripcion = new DataGridViewTextBoxColumn {
                Name = "Descripcion",
                HeaderText = "Descripción",
                DataPropertyName = "Descripcion",
                Width = 265
            };

            grid.Columns.AddRange(colId, colTipo, colImporte, colDescripcion);
        }
    }
}
