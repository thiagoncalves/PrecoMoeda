using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoMoeda
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Digite um valor em real para conversão em moedas estrangeiras");
            Console.Write("R$: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            double valorDolar = ConversaoDollar(valor);
            double valorEuro = ConversaoEuro(valor);
            double valorYen = ConversaoYen(valor);

            Console.WriteLine("O valor convertido para dolar é $" + valorDolar.ToString(".00"));
            Console.WriteLine("O valor convertido para euro é €" + valorEuro.ToString(".00"));
            Console.WriteLine("O valor convertido para yen é ¥" + valorYen.ToString(".00"));

            Console.ReadLine();

        }

        public static double ConversaoDollar (int valor)
        {
            double resultado = valor / 5.53;
            return resultado;
        }

        public static double ConversaoEuro (int valor)
        {
            double resultado = valor / 6.03;
            return resultado;
        }

        public static double ConversaoYen (int valor)
        {
            double resultado = valor / 0.051;
            return resultado;
        }
    }
}
