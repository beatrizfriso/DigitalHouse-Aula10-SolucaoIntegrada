namespace Aula10_solucao_integrada
{
    internal class Program
    {
        public class Calculadora
        {
            //calcular ano de nascimento
            //converter dolares
            //fazer operacoes basicas
            public string NomeDoUsuario = string.Empty;
            public int IdadeDoUsuario;
            private int AnoAtual = 2022;
            public int AnoDeNascimento;
            public int CalculaAnoNascimento()
            {
                return this.AnoDeNascimento = this.AnoAtual - IdadeDoUsuario;
            }
        }
        public class Filmes
        {
            //fazer movimentacoes dos filmes

        }

        static void Main(string[] args)
        {
            Calculadora calculadora = new();
            Console.Beep();
            Console.Clear();

            Console.Write("Para o calculo do ano de nascimento, qual seu nome? > ");
            calculadora.NomeDoUsuario = (Convert.ToString(Console.ReadLine()));
            Console.Write("Para o calculo do ano de nascimento, qual sua idade atual? > ");
            calculadora.IdadeDoUsuario = (Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine($"Ano de nascimento = {calculadora.CalculaAnoNascimento()}");


        }
    }
}