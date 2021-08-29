using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empleado;

namespace EmpleadoMode
{
   
    public class EmpleadoModel
    {
        private Empleado1[] empleado;

        public EmpleadoModel() { }
        public void add(Empleado1 e)
        {
            if (e==null)
            {
                throw new ArgumentException("Error, el empleado no puede ser null");
            }
            if (empleado==null)
            {
                empleado = new Empleado1[1];
                empleado[0] = e;
                return;
            }
            Empleado1[] tmp = new Empleado1[empleado.Length+1];
            Array.Copy(empleado,tmp,empleado.Length);
            tmp[tmp.Length - 1] = e;
            empleado = tmp;
            
        }
        public Empleado1[] GetEmpleado1()
        {
            return this.empleado;
        }
        public decimal GetSalarioMaximo()
        {
            decimal max = decimal.MinValue;
            foreach (Empleado1 e in empleado)
            {
                if (e.Salario>max)
                {
                    max = e.Salario;
                }
            }
            return max;
        }
        public decimal GetSalarioMinimo()
        {
            decimal max = decimal.MaxValue;
            foreach (Empleado1 e in empleado)
            {
                if (e.Salario < max)
                {
                    max = e.Salario;
                }
            }
            return max;
        }
    }
}
