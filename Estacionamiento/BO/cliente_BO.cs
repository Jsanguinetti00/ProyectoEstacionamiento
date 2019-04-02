using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class cliente_BO
    {
        private int id_cliente;
        private string nombre;
        private string apellido_paterno;
        private string apellido_materno;
        private string telefono;
        private int edad;
        private string direccion;
        private int fk_id_tarifa;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Fk_id_tarifa { get => fk_id_tarifa; set => fk_id_tarifa = value; }
    }
}
