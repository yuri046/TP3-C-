using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_10_a_12
{
    internal class Esfera
    {
        public double raio;
        public const double Pi = 3.14159;

        public Esfera(double raio)
        {
            this.raio = raio;
        }

        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (raio *  raio * raio);
        }
    }
}
