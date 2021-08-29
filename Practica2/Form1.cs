using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Empleado;
using EmpleadoMode;

namespace Practica2
{
    public partial class Form1 : Form
    {
        EmpleadoModel empMod;
        public Form1()
        {
            empMod = new EmpleadoModel();
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string nombres, apellidos, dni;
            decimal salario;
            try
            {
                nombres = txtNombres.Text;
                apellidos = txtApellidos.Text;
                dni = txtDNI.Text;
                ValidateEmpleado(nombres,apellidos,dni,txtSalarios.Text) ;
                salario = decimal.Parse(txtSalarios.Text);
                Empleado1 emp = new Empleado1()
                {
                    DNI = dni,
                    Nombres=nombres,
                    Apellidos=apellidos,
                    Salario=salario,

                };
                empMod.add(emp);
                MessageBox.Show($@"
                Nombres: {txtNombres.Text}{Environment.NewLine}
                Apellidos: {txtApellidos.Text}{Environment.NewLine}
                DNI: {txtDNI.Text}{Environment.NewLine}
                Salario: {txtSalarios.Text}{Environment.NewLine}");
                CleanTexBox();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void ValidateEmpleado(string nombre,string apellido,string dni,string salario)
        {
            string sidni = @"\d{3}-\d{6}-\d{4}[A-Z]{1}";
            if (string.IsNullOrWhiteSpace(nombre)||string.IsNullOrWhiteSpace(apellido)||
                string.IsNullOrWhiteSpace(dni)||string.IsNullOrWhiteSpace(salario))
            {
                throw new ArgumentException("Error, todos todos los datos son requeridos");
            }
           /* if (!Regex.Match(dni,sidni).Success)
            {
                throw new ArgumentException("Error, el dni no tiene el formato correcto: [000-000000-0000U]");
            }*/
            if (string.IsNullOrEmpty(nombre)||string.IsNullOrEmpty(apellido))
            {
                throw new ArgumentException("Error, Nombres o Apellidos no pueden ser vacios");
            }
            if (Name.Length > 20 || apellido.Length > 20)
            {
                throw new ArgumentException("Error, maximo de caracteres permitidos es 20");
            }
            if (!decimal.TryParse(txtSalarios.Text,out decimal salari))
            {
                throw new ArgumentException($@"Error, esto{txtSalarios.Text} no es un salario");
            }
        }
        private void CleanTexBox()
        {
            txtApellidos.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtSalarios.Text = string.Empty;
        }

        private void Salarios_Click(object sender, EventArgs e)
        {

        }

        private void btnSmaximo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Salario Maximo: {empMod.GetSalarioMaximo()}");
        }

        private void btnSminimo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Salario Maximo: {empMod.GetSalarioMinimo()}");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
