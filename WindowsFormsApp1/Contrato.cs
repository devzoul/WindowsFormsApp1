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
        public String estaVigente { get; set; }
        public int id_modalidad { get; set; }
        public int id_tipoevento { get; set; }
        public String observaciones { get; set; }
        public String rutCliente { get; set; }
        public int asistentes { get; set; }
        public int participantes { get; set; }
        public int valortotalcontrato { get; set; }


        public Contrato() { }

        public Contrato(long numeroContrato, string creacion, string termino, string fechaHoraInicio, string fechaHoraTermino, string estaVigente, int id_modalidad, int id_tipoevento, string observaciones, string rutCliente, int asistentes, int participantes, int valortotalcontrato)
        {
            this.numeroContrato = numeroContrato;
            this.creacion = creacion;
            this.termino = termino;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraTermino = fechaHoraTermino;
            this.estaVigente = estaVigente;
            this.id_modalidad = id_modalidad;
            this.id_tipoevento = id_tipoevento;
            this.observaciones = observaciones;
            this.rutCliente = rutCliente;
            this.asistentes = asistentes;
            this.participantes = participantes;
            this.valortotalcontrato = valortotalcontrato;
        }
    }
    
}
