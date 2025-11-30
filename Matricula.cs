using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_7a9
{
    internal class Matricula
    {
        private string _nomeDoAluno;
        private string _curso;
        private int _numeroMatricula;
        private string _situacao; //"Ativa", "Trancada", "Concluída"
        private string _dataInicial;

        public string NomeDoAluno { get => _nomeDoAluno; set => _nomeDoAluno = value; }
        public string Curso { get => _curso; set => _curso = value; }
        public int NumeroMatricula { get => _numeroMatricula; set => _numeroMatricula = value; }
        public string Situacao { get => _situacao; set => _situacao = value; }
        public string DataInicial { get => _dataInicial; set => _dataInicial = value; }

        public string Trancar()
        {
            Console.WriteLine("A matrícula está trancada");
            Situacao = "Trancada";
            return Situacao;
        }
        public string Reativar()
        {
            Console.WriteLine("A matrícula está reativada");
            Situacao = "Ativa";
            return Situacao;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Informações do Aluno: ");
            Console.WriteLine($"Nome: {NomeDoAluno}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Matricula: {NumeroMatricula}");
            Console.WriteLine($"Situação atual: {Situacao}");
            Console.WriteLine($"Data de matricula: {DataInicial}");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
