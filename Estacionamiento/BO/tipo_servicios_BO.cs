using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class tipo_servicios_BO
    {
        private int id_servicio;
        private string tipo_servicio;

        public int Id_servicio { get => id_servicio; set => id_servicio = value; }
        public string Tipo_servicio { get => tipo_servicio; set => tipo_servicio = value; }
    }
}
