using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios_2_ao_6
{
    internal class AppIngresso
    {
        public static void Main(String[] args)
        {
            Ingresso ingresso = new Ingresso("Exaltasamba", 150, 1000);

            ingresso.AlterarPreco(200);
            ingresso.AlterarQuantidade(2000);
            ingresso.ExibirInformacoes();

            ingresso.SetPreco(300);
            Console.WriteLine($"Novo preço: {ingresso.GetPreco()}");
        }
    }
}
