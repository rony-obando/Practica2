using Empleado.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class Empleado1
    {
        public int Id { get; set; }
        public string Nombres
        {
            get;set;
        }
        public string Apellidos
        {
            get;set;
        }
        public string DNI
        {
            get;set;
        }
        public decimal Salario
        {
            get;set;
        }
        public NivelAcademico nivelAcademico { get; set; }
        public Genero Generos { get; set; }
        public class SalarioComparer : IComparer<Empleado1>
        {
            public int Compare(Empleado1 x, Empleado1 y)
            {
                if (x.nivelAcademico > y.nivelAcademico)
                {
                    return -1;
                }
                else if (x.nivelAcademico < y.nivelAcademico)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
        }
    }
}
