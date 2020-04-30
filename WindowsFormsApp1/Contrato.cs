using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Contrato
    {
        public int numeroContrato { get; set; }
        public DateTime creacion { get; set; }
        public DateTime termino { get; set; }
        public DateTime fechaHoraInicio { get; set; }
        public DateTime fechaHoraTermino { get; set; }
        public String direccionCon { get; set; }
        public String estaVigente { get; set; }
        public int tipoCon { get; set; }
        public String observaciones { get; set; }


        public Contrato() { }

        public Contrato(int numeroContrato, DateTime creacion, DateTime termino, DateTime fechaHoraInicio, DateTime fechaHoraTermino, string direccionCon, string estaVigente, int tipoCon, string observaciones)
        {
            this.numeroContrato = numeroContrato;
            this.creacion = creacion;
            this.termino = termino;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraTermino = fechaHoraTermino;
            this.direccionCon = direccionCon;
            this.estaVigente = estaVigente;
            this.tipoCon = tipoCon;
            this.observaciones = observaciones;
        }
    }
}
