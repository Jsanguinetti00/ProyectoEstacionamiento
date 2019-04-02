using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class Empleado_BO
    {
        private int id_empleado;
        private string curp;
        private string nombres;
        private string apellido_paterno;
        private string apellido_materno;
        private int edad;
        private string direccion;
        private string telefono;
        private int fk_id_empresa;
        private int fk_id_turno;

        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Curp { get => curp; set => curp = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Fk_id_empresa { get => fk_id_empresa; set => fk_id_empresa = value; }
        public int Fk_id_turno { get => fk_id_turno; set => fk_id_turno = value; }
    }
}
