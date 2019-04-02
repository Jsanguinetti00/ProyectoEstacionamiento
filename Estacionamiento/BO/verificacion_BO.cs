using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class verificacion_BO
    {
        private string no_usuario;
        private string contraseña;

        public string No_usuario { get => no_usuario; set => no_usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
