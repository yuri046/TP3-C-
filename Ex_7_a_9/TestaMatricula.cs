using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios_7_ao_9
{
    internal class TestaMatricula
    {
        public static void Main(string[] args)
        {
            Matricula matricula = new("Luis", "Eng. de Software", 1, "Ativa", "10/01/2024");

            matricula.Trancar();
            matricula.ExibirInformacoes();
            matricula.Reativar();
            matricula.ExibirInformacoes();

        }
    }
}
