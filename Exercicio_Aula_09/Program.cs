using System;
using System.Globalization;

namespace Exercicio_Aula_09
{
    public class Calculadora {
       //Variáveis.
        public double resultado = 0;
        public double valor;
        public void somarValor()
        {
            this.resultado += this.valor;
            Console.WriteLine("O resultado é: " + this.resultado);
        }

        public void subtrairValor()
        {
            this.resultado -= this.valor;
            Console.WriteLine("O resultado é: " + this.resultado);
        }

        public void dividirValor()
        {
            this.resultado /= this.valor;
            Console.WriteLine("O resultado é: " + this.resultado);
        }

        public void multiplicarValor()
        {
            this.resultado *= this.valor;
            Console.WriteLine("O resultado é: " + this.resultado);
        }

        public void zerarResultado()
        {
            this.resultado = 0;
            Console.WriteLine("O resultado é: " + this.resultado);
        }

        public void definirResultadoDaUltimaOperacaoMatematica()
        {
            double novoValor;
            Console.WriteLine("Digite o novo valor: ");
            novoValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            this.resultado = novoValor;
        }

        public void pegarResultadoDaUltimaOperacaoMatematica()
        {
            this.resultado = this.resultado;
            Console.WriteLine("O resultado é: " + this.resultado);
        }
        public double getValor()
        {
            return this.resultado;
        }
        public void setValor(double valor)
        {
            this.valor = valor;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora novaCalculadora = new Calculadora();
            try
            {
                for (; ; )
                {
                    Console.WriteLine("Escolha qual operação deseja realizar: ");
                    Console.WriteLine("1 - Somar");
                    Console.WriteLine("2 - Subtrair ");
                    Console.WriteLine("3 - Dividir");
                    Console.WriteLine("4 - Multiplicar");
                    Console.WriteLine("5 - Zerar a calculadora");
                    Console.WriteLine("6 - Digite o valor da próxima operação:");
                    Console.WriteLine("7 - Pegar resultado da ultima operação:");
                    double Operador = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (Operador == 1)
                    {
                        Console.WriteLine("Você digitou 1 - Somar");
                        Console.WriteLine("Qual valor deseja somar?");
                        novaCalculadora.setValor(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        novaCalculadora.somarValor();
                    }
                    else if (Operador == 2)
                    {
                        Console.WriteLine("Você digitou 2 - Subtrair");
                        Console.WriteLine("Qual valor deseja subtrair?");
                        novaCalculadora.setValor(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        novaCalculadora.subtrairValor();
                    }
                    else if (Operador == 3)
                    {
                        Console.WriteLine("Você digitou 3 - Dividir");
                        Console.WriteLine("Qual valor deseja dividir?");
                        novaCalculadora.setValor(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        novaCalculadora.dividirValor();
                    }
                    else if (Operador == 4)
                    {
                        Console.WriteLine("Você digitou 4 - Multiplicar");
                        Console.WriteLine("Qual valor deseja multiplicar?");
                        novaCalculadora.setValor(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        novaCalculadora.multiplicarValor();
                    }
                    else if (Operador == 5)
                    {
                        Console.WriteLine("Você digitou 5 - Zerar calculadora");
                        novaCalculadora.zerarResultado();
                    }
                    else if (Operador == 6)
                    {
                        novaCalculadora.definirResultadoDaUltimaOperacaoMatematica();
                    }
                    else
                    {
                        novaCalculadora.pegarResultadoDaUltimaOperacaoMatematica();
                    }

                }

            }
            catch (Exception erro)
            {
                Console.WriteLine("CodError002 - O usuário não pode inserir qualquer valor além de números.");
                Console.WriteLine(erro.GetType());
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
            }
            finally
            {
                Console.WriteLine("Reinicie o programa...");
            }
        }
    }
}