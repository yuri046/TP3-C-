using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_10_a_12
{
    internal class TestaFiguras
    {
        public static void Main(string[] args)
        {
            Circulo circulo = new(3);
            Esfera esfera = new(5);

            Console.WriteLine($"Área do circulo: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Volume da esfera: {esfera.CalcularVolume():F2}");

        }
        

        
    }
}
