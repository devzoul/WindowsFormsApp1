using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TipoEmpresa
    {
        public int idTipoEmpresa { get; set; }
        public String Descripcion { get; set; }
        

        public TipoEmpresa() { }

        public TipoEmpresa(int idTipoEmpresa, string Descripcion)
        {
            this.idTipoEmpresa = idTipoEmpresa;
            this.Descripcion = Descripcion;
        }
    }
}
