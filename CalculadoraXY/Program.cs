using System;


namespace CalculadoraXY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            double num1;
            double num2; 
            double num3;

            Console.Write("Insira o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("Insira o terceiro número: ");
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("O resultado da adição é: " + Calculadora.SomarNumeros(num1,num2));
            Console.WriteLine();
            Console.Write("O resultado da subtração de (x,y): " + Calculadora.SubtrairNumeros(num1,num2));
            Console.WriteLine();
            Console.Write("O resultado da divisão de (x,y): " + Calculadora.DividirNumeros(num1, num2));
            Console.WriteLine();
            Console.Write("O resultado da multiplicação de (x,y): " + Calculadora.MultiplicarNumeros(num1, num2));
            Console.WriteLine();
            Console.Write("O resultado da potência de (x,y): " + Calculadora.PotenciaNumeros(num1, num2));
            Console.WriteLine();
            Console.Write("O resultado da equação 2º grau: "+ "\n" + Calculadora.Baskara1(num1, num2, num3));
      
            Console.ReadKey();
         

        }
    }
}
