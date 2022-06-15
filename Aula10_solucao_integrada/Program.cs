using System;
using System.Collections.Generic;

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
            //fazer operacoes basicas - aula09 - atividade1
            public double ValorDigitado = 0.00f;
            public int OperacaoEscolhida = 0;
            private List<string> MemoriaCalculadora = new () { }; //https://www.educba.com/list-in-c-sharp/
            internal double Resultado;
            private List<string> OpcoesDeMenu = new() { "Sair", "Somar", "Subtrair", "Multiplicar", "Dividir", "Zerar Calculadora" };
            private bool Calculando;
            //
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
            public void MostraMemoriaEPilhaOperacoes()
            {
                Console.WriteLine($"Valor da memória: [ {this.Resultado} ]\n");
                Console.Write("Operações: ");

                foreach (string OneDetail in this.MemoriaCalculadora)
                {
                    Console.Write(OneDetail);
                }
                Console.WriteLine("\n\n");                
            }
            public void DesenhaCalculadora()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red; 
                this.Calculando = true;
                MostraMemoriaEPilhaOperacoes();
                Console.WriteLine(
                    $"Escolha qual operação deseja realizar:\n" +
                    $"1 - {OpcoesDeMenu[1]}\n" +
                    $"2 - {OpcoesDeMenu[2]}\n" +
                    $"3 - {OpcoesDeMenu[3]}\n" +
                    $"4 - {OpcoesDeMenu[4]}\n" +
                    $"5 - {OpcoesDeMenu[5]}\n" +
                    $"0 - {OpcoesDeMenu[0]}"
                );
            }
            internal void AlimentaPilhaOperacoes(bool Zerar)
            {
                if (Zerar)
                {
                    MemoriaCalculadora.Clear();
                }
                else
                {
                    this.MemoriaCalculadora.Add($"{this.OpcoesDeMenu[OperacaoEscolhida]} {this.ValorDigitado}|");
                }  
            }
            public void InformaOpcaoEscolhida()
            {
                if (OperacaoEscolhida >= 0 && OperacaoEscolhida < OpcoesDeMenu.Count)
                {
                    Console.WriteLine($"Você digitou {OperacaoEscolhida} - {OpcoesDeMenu[OperacaoEscolhida]}");
                }
                else
                {
                    Console.WriteLine($"Você digitou {OperacaoEscolhida} - inválida");
                }
            }
            public bool IsCalculando()
            {
                return this.Calculando;
            }
            public bool FinalizarCalculadora()
            {
                AlimentaPilhaOperacoes(true);
                Console.Beep();
                Console.Clear();
                this.Calculando = false;
                //Always return false, to finish the main loop
                return false;
            }
            public double SomarValores(double ValorUsuario)
            {
                this.ValorDigitado = ValorUsuario;
                this.Resultado += this.ValorDigitado;
                AlimentaPilhaOperacoes(false);
                return this.Resultado;
            }
            public double SubtrairValores(double ValorUsuario)
            {
                this.ValorDigitado = ValorUsuario;
                this.Resultado -= this.ValorDigitado;
                AlimentaPilhaOperacoes(false);
                return this.Resultado;
            }
            public double MultiplicarValores(double ValorUsuario)
            {
                this.ValorDigitado = ValorUsuario;
                this.Resultado *= this.ValorDigitado;
                AlimentaPilhaOperacoes(false);
                return this.Resultado;
            }
            public double DividirValores(double ValorUsuario)
            {
                try
                {
                    this.ValorDigitado = ValorUsuario;
                    this.Resultado /= this.ValorDigitado;
                    AlimentaPilhaOperacoes(false);
                }
                catch (DivideByZeroException e)
                {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine(e.ToString());
                }
                return this.Resultado;
            }
            public bool ZerarResultado()
            {
                this.Resultado = 0;
                AlimentaPilhaOperacoes(false);
                return true;
            }
            public int LerEntradaUsuario()
            {
                try
                {
                    this.OperacaoEscolhida = Convert.ToInt16(Console.ReadLine());
                    InformaOpcaoEscolhida();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro tratado: " + ex.Message);
                }

                if (this.OperacaoEscolhida > 0 && OperacaoEscolhida != 5 && OperacaoEscolhida < OpcoesDeMenu.Count)
                {
                    try
                    {
                        Console.Write($"Qual valor deseja {OpcoesDeMenu[OperacaoEscolhida]}? ");
                        Double.TryParse(Console.ReadLine(), out this.ValorDigitado);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro tratado: " + ex.Message);
                    }
                }
                switch (OperacaoEscolhida)
                {
                    case 1:
                        SomarValores(ValorDigitado);
                        break;
                    case 2:
                        SubtrairValores(ValorDigitado);
                        break;
                    case 3:
                        MultiplicarValores(ValorDigitado);
                        break;
                    case 4:
                        DividirValores(ValorDigitado);
                        break;
                    case 5:
                        ZerarResultado();
                        break;
                    case 0:
                        FinalizarCalculadora();
                        break;
                }

                if (OperacaoEscolhida > 0)
                {
                    Console.WriteLine($"O resultado é {this.Resultado}");
                }
                return 0;
            }
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
            //
            // aula06 - atividade 1: calcular ano de nascimento
            //
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
            //
            // aula07 - atividade 1: conversao para dolares e conferencia de limites de transacoes
            //
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
            Console.WriteLine("Leia a informação e aperte ENTER para seguir.");
            Console.ReadKey();
            //
            //aula08 - atividade 1 - controle e movimentacao de filmes.
            //
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Controle e movimentação de filmes");
            //
            //aula09 - atividade 1 - calculadora com operacoes basicas.
            //
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Calculador com operações básicas");
            do
            {
                calculadora.DesenhaCalculadora();
                calculadora.LerEntradaUsuario();
            } while (calculadora.IsCalculando());

            Environment.Exit(0);
        }
    }
}