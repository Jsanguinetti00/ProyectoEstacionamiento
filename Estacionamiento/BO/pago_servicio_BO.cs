using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class pago_servicio_BO
    {

        private int folio_servicio;
        private DateTime fecha_servicio;
        private double total_pago;
        private int fk_id_servicio;
        private int fk_id_empleado;
        private int fk_id_corte;

        public int Folio_servicio { get => folio_servicio; set => folio_servicio = value; }
        public DateTime Fecha_servicio { get => fecha_servicio; set => fecha_servicio = value; }
        public double Total_pago { get => total_pago; set => total_pago = value; }
        public int Fk_id_servicio { get => fk_id_servicio; set => fk_id_servicio = value; }
        public int Fk_id_empleado { get => fk_id_empleado; set => fk_id_empleado = value; }
        public int Fk_id_corte { get => fk_id_corte; set => fk_id_corte = value; }
    }
}
