namespace Aula10_solucao_integrada
{
    internal class Program
    {
        public class Calculadora
        {
            //calcular ano de nascimento - aula06 - atividade1
            public string NomeDoUsuario = string.Empty;
            public int IdadeDoUsuario;
            private readonly int AnoAtual = 2022;    //testando resultado com private
            public int AnoDeNascimento;
            //converter dolares e checar limites - aula07 - atividade1
            public decimal CotacaoDoDolarHoje;
            public decimal ValorDaCompraUsuario;
            public decimal ValorMinimoDeCompraEmDolar = 100;
            public decimal ValorMaximoDeCompraEmDolar = 2500;
            public decimal valorDaCompraEmDolares;
            internal decimal ValorDaCompraEmDolares { get => valorDaCompraEmDolares; set => valorDaCompraEmDolares = value; }
            
            //Methods
            //calcular ano de nascimento - aula06 - atividade1
            public int CalculaAnoNascimento()
            {
                return this.AnoDeNascimento = this.AnoAtual - IdadeDoUsuario;
            }
            //converter dolares e checar limites - aula07 - atividade1
            private decimal ConverterRealParaDolar()
            {
                try
                {
                    this.ValorDaCompraEmDolares = this.ValorDaCompraUsuario / this.CotacaoDoDolarHoje;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message, e.InnerException);
                }
                return this.ValorDaCompraEmDolares;
            }

            public void ChecarLimitesValidosDeCompraEmDolares()
            {
                this.ValorDaCompraEmDolares = ConverterRealParaDolar();
                Console.Beep();

                if (this.ValorDaCompraEmDolares < this.ValorMinimoDeCompraEmDolar)
                {
                    Console.WriteLine($"\t\t\tValor mínimo permitido é de $ {this.ValorMinimoDeCompraEmDolar}. Solicitado: ${this.ValorDaCompraEmDolares}");
                }
                else if (this.ValorDaCompraEmDolares > this.ValorMaximoDeCompraEmDolar)
                {
                    Console.WriteLine($"\t\t\tValor máximo permitido é de $ {this.ValorMaximoDeCompraEmDolar}. Solicitado: ${this.ValorDaCompraEmDolares}");
                }
                else
                { 
                    Console.WriteLine($"\t\t\tCompra de R$ {this.ValorDaCompraUsuario} = $ {this.ValorDaCompraEmDolares} aceita.");
                }
            }
            //fazer operacoes basicas
        }
        public class Filmes
        {
            //fazer movimentacoes dos filmes

        }

        static void Main()
        {
            Calculadora calculadora = new();
            Console.Beep();
            Console.Clear();

            // aula06 - atividade 1: calcular ano de nascimento
            Console.WriteLine("Calculando ano de nascimento");
            Console.Write("Para o calculo do ano de nascimento, qual seu nome? > ");
            try
            {
                calculadora.NomeDoUsuario = Console.ReadLine();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

            Console.Write("Para o calculo do ano de nascimento, qual sua idade atual? > ");
            try
            {
                calculadora.IdadeDoUsuario = Convert.ToInt16(Console.ReadLine()); //set
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

            Console.WriteLine($"Ano de nascimento = {calculadora.CalculaAnoNascimento()}\n\n");

            // aula07 - atividade 1: conversao para dolares e conferencia de limites de transacoes
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Calculando e verificando compra em dólares");
            Console.Write("Para o calculo da compra de dólares, qual cotacao do $ em R$? > ");
            try
            {
                calculadora.CotacaoDoDolarHoje = Convert.ToDecimal(Console.ReadLine());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            Console.Write("Para o calculo da compra de dólares, quanto quer comprar, em R$? > ");
            try
            {
                calculadora.ValorDaCompraUsuario = Convert.ToDecimal(Console.ReadLine());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            
            calculadora.ChecarLimitesValidosDeCompraEmDolares();

            //aula08 - atividade 1 - controle e movimentacao de filmes.
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Controle e movimentação de filmes");

            //aula09 - atividade 1 - calculadora com operacoes basicas.
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Calculador com operações básicas");
        }
    }
}