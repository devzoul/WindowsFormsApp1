using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public String usuario { get; set; }
        public String contraseña { get; set; }

        public Usuario()
        { }

        public Usuario(int idUsuario, string usuario, string contraseña)
        {
            this.idUsuario = idUsuario;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

    }
}
