using System;

namespace Exercicio_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
             double A, B, C, X1, X2, Delta;

             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("--------Bhaskara--------");
             Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Escreva o valor A: ");
            A = double.Parse(Console.ReadLine());

            Console.Write("Escreva o valor B: ");
            B = double.Parse(Console.ReadLine());

            Console.Write("Escreva o valor C: ");
            C = double.Parse(Console.ReadLine());
            Console.ResetColor();


                 Delta = Math.Pow (B, 2) - 4 * A * C;

                X1 = (-B + Math.Sqrt(Delta)) / 2 * A;
                X2 = (-B - Math.Sqrt(Delta)) / 2 * A;

            Console.WriteLine();

             Console.ForegroundColor = ConsoleColor.Green;
             Console.Write("O valor de x1 é ");
             Console.WriteLine(Math.Round(X1, 2));

             Console.Write("O valor de x2 é ");
             Console.WriteLine(Math.Round(X2, 2));


            if (A == 0)
            {
                Console.Write("Isso não é uma equação de segundo grau!");
            }

            else if (Delta < 0) 
            {
                Console.Write($"Como delta = {Delta}, a equação não possui raízes reais!");
            }
            Console.ResetColor();
        }   
    }
}
