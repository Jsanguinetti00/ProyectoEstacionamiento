using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class tarifa_BO
    {
        private int id_tarifa;
        private double costo_tarifa;
        private string tiempo_aplicado;

        public int Id_tarifa { get => id_tarifa; set => id_tarifa = value; }
        public double Costo_tarifa { get => costo_tarifa; set => costo_tarifa = value; }
        public string Tiempo_aplicado { get => tiempo_aplicado; set => tiempo_aplicado = value; }
    }
}
