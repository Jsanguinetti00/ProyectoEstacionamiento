using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class vehiculo_BO
    {
        private int fk_id_cliente;
        private string matricula;
        private string modelo;

        public int Fk_id_cliente { get => fk_id_cliente; set => fk_id_cliente = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
