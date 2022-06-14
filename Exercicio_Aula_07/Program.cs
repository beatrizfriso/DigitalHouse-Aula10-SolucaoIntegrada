using System;
using System.Globalization;

namespace Exercicio_Aula_07
{
    public class Conversao
    {
        //variáveis
        public double cotacaoDoDolarHoje = 4.97;
        public double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
        public double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;
        public double valorConvertidoDaCompra;
        public double valorCompraUsuario;

        //métodos
        public void converterRealParaDolar()
        {
            this.valorConvertidoDaCompra = this.valorCompraUsuario / this.cotacaoDoDolarHoje;
        }
        public void checarMaxMin()
        {
            converterRealParaDolar();
            if (this.valorConvertidoDaCompra > 2500)
            {
                Console.WriteLine($"A compra máxima permitida é de ${this.VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}");
            }  
            else if (this.valorConvertidoDaCompra < 100)
            {
                Console.WriteLine($"A compra mínimo permitida é de ${this.VALOR_MINIMO_DE_COMPRA_EM_DOLAR}");                
            } 
            else
            {
                Console.WriteLine("Você pode comprar: $" + this.valorConvertidoDaCompra.ToString("F2",CultureInfo.InvariantCulture));
            }            

        }
        
        public double getValorCompraUsuario()
        {
            return valorCompraUsuario;
        }
        public void setValorCompraUsuario(double valorCompraUsuario)
        {
            this.valorCompraUsuario = valorCompraUsuario;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Conversao conversaoDolarReal = new Conversao();
                Console.WriteLine("Qual foi o valor da compra em reais?");
                conversaoDolarReal.setValorCompraUsuario(double.Parse(Console.ReadLine()));
                conversaoDolarReal.checarMaxMin();    
                
               
            }
        }
    }
}

