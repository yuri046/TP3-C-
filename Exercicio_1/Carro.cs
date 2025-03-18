using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicio_1
{
    internal class Carro
    {
        private String modelo;
        private int ano;

        public Carro(String modelo, int ano)
        {
            this.modelo = modelo;
            this.ano = ano;
        }

        public void exibirInformacoes()
        {
            Console.WriteLine("Modelo: " + modelo + "\nAno: " + ano);
        }
    }
}
