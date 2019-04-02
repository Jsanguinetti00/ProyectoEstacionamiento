using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.BO
{
    class mensaje_BO
    {
        private Int64 numero;
        private int comproveri;
        private int codigoveri;

        public Int64 Numero { get => numero; set => numero = value; }
        public int Comproveri { get => comproveri; set => comproveri = value; }
        public int Codigoveri { get => codigoveri; set => codigoveri = value; }

        public string conversion()
        {
            string conver = "+52" + numero.ToString();
            return conver;
        }
    }
}
