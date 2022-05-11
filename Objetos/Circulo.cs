using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public static class Circulo
    {
        public static decimal Area(decimal radio)
        {
            return Convert.ToDecimal(Math.PI) * radio * radio;
        }

        public static decimal AreaError(decimal radio)
        {
            return Convert.ToDecimal(Math.PI) * radio;
        }
    }
}