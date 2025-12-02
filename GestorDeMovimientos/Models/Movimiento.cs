using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMovimientos.Models {
    public class Movimiento {
        public int Id { get; set; }              // Clave primaria
        public string Tipo { get; set; }         // "Ingreso" o "Gasto"
        public decimal Importe { get; set; }     // Cantidad money
        public string Descripcion { get; set; }  // Detalles del movimiento
    }
}
