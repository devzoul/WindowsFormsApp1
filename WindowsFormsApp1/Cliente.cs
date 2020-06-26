using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cliente
    {
        public String rutCli { get; set;}
        public String razon_social { get; set; }
        public String nombreContactoCli { get; set; }
        public String mailContacto { get; set; }
        public String direccionCli { get; set; }
        public int telefono { get; set; }
        public String actividad { get; set; }
        public String tipoCli { get; set; }
        public String nom_tipo { get; set; }
        public String nom_actividad { get; set; }



        public Cliente()
        {}

        public Cliente(string rutCli, string razon_social, string nombreContactoCli, 
                        string mailContacto, string direccionCli, int telefono, string actividad,
                        string tipoCli, string nom_tipo, string nom_actividad)
        {
            this.rutCli = rutCli;
            this.razon_social = razon_social;
            this.nombreContactoCli = nombreContactoCli;
            this.mailContacto = mailContacto;
            this.direccionCli = direccionCli;
            this.telefono = telefono;
            this.actividad = actividad;
            this.tipoCli = tipoCli;
            this.nom_tipo = nom_tipo;
            this.nom_actividad = nom_actividad;
        }
    }
}
