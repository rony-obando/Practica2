using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empleado;
using EmpleadoMode;

namespace Practica2
{
    public partial class FormProducto : Form
    {
        
        ProductoModel PModel;
        public FormProducto()
        {
             PModel=new ProductoModel();
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {

        }

        
        private void Enviar_Click(object sender, EventArgs e)
        {
            string nombre, descripcion;
            DateTime caducidad;
            int codigo, cantidad;
            decimal precio;
            try
            {
                ValidateProducto(txtNombre.Text,txtDescripcion.Text,txtCodigo.Text,txtCantidad.Text,txtCaducidad.Text,txtPrecio.Text);
                nombre = txtNombre.Text;
                descripcion = txtDescripcion.Text;
                caducidad = DateTime.Parse(txtCaducidad.Text);
                codigo = int.Parse(txtCodigo.Text);
                cantidad = int.Parse(txtCantidad.Text);
                precio = decimal.Parse(txtPrecio.Text);
                Producto producto = new Producto()
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Caducidad=caducidad,
                    Codigo=codigo,
                    Cantidad=cantidad,
                    Precio=precio,
                };
                PModel.Add(producto);
                txtCaducidad.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                txtCodigo.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtPrecio.Text = string.Empty;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre, descripcion;
            DateTime caducidad;
            int codigo, cantidad;
            decimal precio;
            try
            {
                ValidateProducto(txtNombre.Text, txtDescripcion.Text, txtCodigo.Text, txtCantidad.Text, txtCaducidad.Text, txtPrecio.Text);
                nombre = txtNombre.Text;
                descripcion = txtDescripcion.Text;
                caducidad = DateTime.Parse(txtCaducidad.Text);
                codigo = int.Parse(txtCodigo.Text);
                cantidad = int.Parse(txtCantidad.Text);
                precio = decimal.Parse(txtPrecio.Text);
                Producto producto = new Producto()
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Caducidad = caducidad,
                    Codigo = codigo,
                    Cantidad = cantidad,
                    Precio = precio,
                };
                PModel.Delete(producto);
                txtCaducidad.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                txtCodigo.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtPrecio.Text = string.Empty;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ValidateProducto(string nombre, string descripcion, string codigo, string cantidad,string caducidad,string precio)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) ||string.IsNullOrWhiteSpace(precio)||
                string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(cantidad)||string.IsNullOrWhiteSpace(cantidad))
            {
                throw new ArgumentException("Error, todos todos los datos son requeridos");
            }
             if (!DateTime.TryParse(txtCaducidad.Text, out DateTime d))
             {
                 throw new ArgumentException("Error, la fecha de caducidad no tiene el formato correcto: [00-00-00]");
             }
            if (nombre.Length > 25)
            {
                throw new ArgumentException("Error, maximo de caracteres permitidos es 20");
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal p))
            {
                throw new ArgumentException($@"Error, esto: {txtPrecio.Text} no es un precio valido");
            }
            if (!int.TryParse(txtCantidad.Text, out int c))
            {
                throw new ArgumentException($@"Error, esto: {txtCantidad.Text} no es una cantidad valida(solo numeros enteros)");
            }
            if (!int.TryParse(txtCodigo.Text, out int cod))
            {
                throw new ArgumentException($@"Error, esto: {txtCodigo.Text} no es un codigo valido(solo numeros esteros)");
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string mostrar = $@"Nombre: {PModel.productos[0].Nombre}
                            Codigo:{PModel.productos[0].Codigo}
                            Descripcion: {PModel.productos[0].Descripcion}
                            Cantidad: {PModel.productos[0].Cantidad}
                            Precio: {PModel.productos[0].Precio}
                            Caducidad: {PModel.productos[0].Caducidad}";
            MessageBox.Show(mostrar, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void buscar(int codigo)
        {
            for (int i = 0; i < PModel.productos.Length; i++)
            {
                if (codigo == PModel.productos[i].Codigo)
                {
                    txtCodigo.Text = $"{codigo}";
                    txtCodigo.Enabled = false;
                    txtNombre.Text = $"{PModel.productos[i].Nombre}";
                    txtPrecio.Text = $"{PModel.productos[i].Precio}";
                    txtCantidad.Text = $"{PModel.productos[i].Cantidad}";
                    txtCaducidad.Text = $"{PModel.productos[i].Descripcion}";

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, descripcion;
            DateTime caducidad;
            int codigo, cantidad;
            decimal precio;
            try
            {
                ValidateProducto(txtNombre.Text, txtDescripcion.Text, txtCodigo.Text, txtCantidad.Text, txtCaducidad.Text, txtPrecio.Text);
                nombre = txtNombre.Text;
                descripcion = txtDescripcion.Text;
                caducidad = DateTime.Parse(txtCaducidad.Text);
                codigo = int.Parse(txtCodigo.Text);
                cantidad = int.Parse(txtCantidad.Text);
                precio = decimal.Parse(txtPrecio.Text);
                Producto producto = new Producto()
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Caducidad = caducidad,
                    Codigo = codigo,
                    Cantidad = cantidad,
                    Precio = precio,
                };
                PModel.Update(producto);
                txtCaducidad.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                txtCodigo.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtPrecio.Text = string.Empty;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
