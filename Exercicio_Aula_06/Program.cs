namespace aula10_exercicio
{
    public class Calculadora
    {
        //variáveis exercício 6
        public string nomeDoUsuario;
        public int idadeDoUsuario = 0;
        public int anoAtual = 2022;
        public int anoNascimento;

        //métodos exercício 6
        public void calcularAnoNascimento()
        {
            this.anoNascimento = (this.anoAtual - this.idadeDoUsuario);
        }

        public void status()
        {
            calcularAnoNascimento();
            Console.WriteLine($"Olá {this.nomeDoUsuario}, você nasceu em {(this.anoNascimento)}");
        }

        public String getNomeDoUsuario()
        {
            return nomeDoUsuario;

        }

        public void setNomeDoUsuario(String nomeDoUsuario)
        {

            this.nomeDoUsuario = nomeDoUsuario;

        }

        public int getIdadeDoUsuario()
        {
            return idadeDoUsuario;
        }

        public void setIdadeDoUsuario(int idadeDoUsuario)
        {
            this.idadeDoUsuario = idadeDoUsuario;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calcAnoNasc = new Calculadora();
            Console.WriteLine("Digite o seu nome: ");
            calcAnoNasc.setNomeDoUsuario(Console.ReadLine());
            Console.WriteLine("Digite a sua idade: ");
            calcAnoNasc.setIdadeDoUsuario(int.Parse(Console.ReadLine()));
            calcAnoNasc.status();
        }
    }
}