using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class Producto
    {
        public Producto()
        {

        }

        public Producto(int codigo, string nombre, string descripcion, int cantidad, decimal precio, DateTime caducidad)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Caducidad = caducidad;
        }

       

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public DateTime Caducidad { get; set; }
    }
}
