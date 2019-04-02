using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class cajon_BO
    {
        private int gencajon;
        private int id_cajon;
        private string numero_cajon;
        private string estatus;
        private int fk_id_estacionamiento;
        private int fk_id_tipocajon;

        public int Id_cajon { get => id_cajon; set => id_cajon = value; }
        public string Numero_cajon { get => numero_cajon; set => numero_cajon = value; }
        
        public int Fk_id_estacionamiento { get => fk_id_estacionamiento; set => fk_id_estacionamiento = value; }
        public int Fk_id_tipocajon { get => fk_id_tipocajon; set => fk_id_tipocajon = value; }
        public string Estatus { get => estatus; set => estatus = value; }
        public int Gencajon { get => gencajon; set => gencajon = value; }
    }
}
