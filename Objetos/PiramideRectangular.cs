using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public static class PiramideRectangular
    {
        public static decimal Volumen(decimal ancho, decimal largo, decimal altura)
        {
            return ancho * largo * altura / 3;
        }
    }
}