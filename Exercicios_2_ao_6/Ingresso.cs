using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios_2_ao_6
{
    internal class Ingresso
    {
        private String nomeDoShow;
        private double preco;
        private int quantidadeDisponivel;

        public Ingresso(String nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        public String GetNomeDoShow()
        {
            return nomeDoShow;
        }

        public void SetNomeDoShow(String novoNome)
        {
            nomeDoShow = novoNome;
        }

        public double GetPreco()
        {
            return preco;
        }

        public void SetPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public int GetQuantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

        public void SetQuantidadeDisponivel(int novaQtd)
        {
            quantidadeDisponivel = novaQtd;
        }
        

        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {nomeDoShow}\nPreço: {preco}\nQuantidade de ingressos: {quantidadeDisponivel}");
        }
    }
}
