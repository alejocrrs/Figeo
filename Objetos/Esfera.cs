using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public static class Esfera
    {
        public static decimal Volumen(decimal radio)
        {
            return 4 * (Convert.ToDecimal(Math.PI) * radio * radio * radio) / 3;
        }
    }
}