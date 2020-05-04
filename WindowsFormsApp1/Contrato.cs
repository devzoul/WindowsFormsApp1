using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Contrato
    {
        public long numeroContrato { get; set; }
        public String creacion { get; set; }
        public String termino { get; set; }
        public String fechaHoraInicio { get; set; }
        public String fechaHoraTermino { get; set; }
        public String direccionCon { get; set; }
        public String estaVigente { get; set; }
        public int idTipo { get; set; }
        public String observaciones { get; set; }

        public String rutCli { get; set; }

        public  String nombreTipo { get; set; }


        public Contrato() { }

        public Contrato(int numeroContrato, String creacion, String termino, String fechaHoraInicio, String fechaHoraTermino, string direccionCon, string estaVigente, int tipoCon, string observaciones, string rutCli)
        {
            this.numeroContrato = numeroContrato;
            this.creacion = creacion;
            this.termino = termino;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraTermino = fechaHoraTermino;
            this.direccionCon = direccionCon;
            this.estaVigente = estaVigente;
            this.idTipo = tipoCon;
            this.observaciones = observaciones;
            this.rutCli = rutCli;
        }
    }
}
