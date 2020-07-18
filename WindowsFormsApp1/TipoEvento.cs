using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TipoEvento
    {
        public int idTipo { get; set; }
        public String nombreTipo { get; set; }




        public TipoEvento() { }

        public TipoEvento(int idTipo, string nombreTipo)
        {
            this.idTipo = idTipo;
            this.nombreTipo = nombreTipo;

        }
    }
}
