using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class tickets_BO
    {
        private int folio_ticket;
        private DateTime fecha_hora_entrada;
        private DateTime fecha_hora_salida;
        private double total_pagar;
        private string matricula;
        private int fk_id_empleado;
        private int fk_id_cajon;
        private int fk_id_tarifa;
        private int fk_id_corte;

        public int Folio_ticket { get => folio_ticket; set => folio_ticket = value; }
        public DateTime Fecha_hora_entrada { get => fecha_hora_entrada; set => fecha_hora_entrada = value; }
        public DateTime Fecha_hora_salida { get => fecha_hora_salida; set => fecha_hora_salida = value; }
        public double Total_pagar { get => total_pagar; set => total_pagar = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int Fk_id_empleado { get => fk_id_empleado; set => fk_id_empleado = value; }
        public int Fk_id_cajon { get => fk_id_cajon; set => fk_id_cajon = value; }
        public int Fk_id_tarifa { get => fk_id_tarifa; set => fk_id_tarifa = value; }
        public int Fk_id_corte { get => fk_id_corte; set => fk_id_corte = value; }
    }
}
