using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class usuario_BO
    {
        private int fk_id_empleado;
        private string usuario;
        private string contraseña;
        private int fk_id_tipo_cuenta;

        public int Fk_id_empleado { get => fk_id_empleado; set => fk_id_empleado = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Fk_id_tipo_cuenta { get => fk_id_tipo_cuenta; set => fk_id_tipo_cuenta = value; }
    }
}
