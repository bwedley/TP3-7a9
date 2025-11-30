namespace TP3_7a9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matricula mat = new Matricula();
            mat.NomeDoAluno = "Bruno Wedley";
            mat.Curso = "Análise e Desenvolvimento de Sistemas";
            mat.NumeroMatricula = 27121993;
            mat.Situacao = "Ativa";
            mat.DataInicial = "01/04/2024";
            Console.WriteLine($"---------------------Informações atuais---------------------");
            mat.ExibirInformacoes();

            mat.Trancar();
            Console.WriteLine($"---------------------Informações Trancada---------------------");
            mat.ExibirInformacoes();

            mat.Reativar();
            Console.WriteLine($"---------------------Informações Reativada---------------------");
            mat.ExibirInformacoes();

        }
    }
}
