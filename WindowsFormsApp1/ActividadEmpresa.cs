using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ActividadEmpresa
    {
        public int IdActividadEmpresa { get; set; }
        public String Descripcion { get; set; }


        public ActividadEmpresa() { }

        public ActividadEmpresa(int IdActividadEmpresa, string Descripcion)
        {
            this.IdActividadEmpresa = IdActividadEmpresa;
            this.Descripcion = Descripcion;
        }
    }
}
