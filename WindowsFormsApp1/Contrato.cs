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

        public int asistentes { get; set; }

        public int participantes { get; set; }

        public int monto_total { get; set; }


        public Contrato() { }

        public Contrato(long numeroContrato, string creacion, string termino, string fechaHoraInicio, string fechaHoraTermino, string direccionCon, string estaVigente, int idTipo, string observaciones, string rutCli, string nombreTipo, int asistentes, int participantes, int monto_total)
        {
            this.numeroContrato = numeroContrato;
            this.creacion = creacion;
            this.termino = termino;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraTermino = fechaHoraTermino;
            this.direccionCon = direccionCon;
            this.estaVigente = estaVigente;
            this.idTipo = idTipo;
            this.observaciones = observaciones;
            this.rutCli = rutCli;
            this.nombreTipo = nombreTipo;
            this.asistentes = asistentes;
            this.participantes = participantes;
            this.monto_total = monto_total;
        }
    }
    
}
