using System;

namespace Funcoes_Structs
{
    class Program
    {
        static int soma(int num1, int num2)
        {
            return num1 + num2;
        }
        static double soma(double num1, double num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            double num1,num2;

            Console.WriteLine("Calculadora");

            Console.WriteLine("Digite um numero");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero");
            num2 = double.Parse(Console.ReadLine());
            double resultado = soma(num1,num2);
            Console.WriteLine("Resultado = " + resultado);

        }
    }
}
