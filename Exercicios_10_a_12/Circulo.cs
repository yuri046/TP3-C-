using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_10_a_12
{
    internal class Circulo
    {
        public double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * raio;
        }
    }
}
