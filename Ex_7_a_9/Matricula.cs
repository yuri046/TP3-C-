using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Exercicios_7_ao_9
{
    internal class Matricula
    {
        public String? nomeDoAluno;
        public String? curso;
        public int? numeroMatricula;
        public String? situacao;
        public String? dataInicial;

        public Matricula(String nomeDoAluno, String curso, int numeroMatricula, String situacao, String dataInicial)
        {
            this.nomeDoAluno = nomeDoAluno;
            this.curso = curso;
            this.numeroMatricula = numeroMatricula;
            this.situacao = situacao;
            this.dataInicial = dataInicial;
        }

        public void Trancar()
        {
            situacao = "Trancada";
        }

        public void Reativar()
        {
            situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do aluno: {nomeDoAluno}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Situação: {situacao}");
            Console.WriteLine($"Data inicial: {dataInicial}");
        }
    }
}
