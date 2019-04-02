using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class turno_BO
    {
        private int id_turno;
        private string hora_inicial;
        private string hora_final;
        private string nombre_turno;

        public string Hora_inicial { get => hora_inicial; set => hora_inicial = value; }
        public string Hora_final { get => hora_final; set => hora_final = value; }
        public string Nombre_turno { get => nombre_turno; set => nombre_turno = value; }
        public int Id_turno { get => id_turno; set => id_turno = value; }
    }
}
