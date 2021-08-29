using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empleado;

namespace EmpleadoMode
{
    public class ProductoModel
    {
        public Producto[] productos;

        public void Add(Producto e)
        {
            if (e == null)
            {
                throw new ArgumentException("Error, no puede ser null") ;
            }
            if (productos==null)
            {
                productos = new Producto[1];
                productos[0] = e;
            }
            else
            {
                Producto[] tmp = new Producto[productos.Length+1];
                Array.Copy(productos,tmp,productos.Length);
                tmp[tmp.Length-1]= e;
                productos = tmp;
            }
        }
        public void Update(Producto e)
        {
            for (int i=0;i<productos.Length;i++)
            {
                if (e.Codigo==productos[1].Codigo)
                {
                    productos[i] = e;
                }
            }
        }
        public void Delete(Producto e)
        {
            for (int i=0;i<productos.Length;i++)
            {
                if (e.Codigo == productos[i].Codigo)
                {
                    productos[i] = productos[productos.Length - 1];
                    Producto[] tmp = new Producto[productos.Length-1];
                    Array.Copy(productos,tmp,productos.Length-1);
                    productos = tmp;
                }
            }
        }
        
    }
}
