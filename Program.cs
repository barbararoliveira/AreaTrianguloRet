using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, vou ajudá-lo a calcular a área de um triângulo. Pressione enter para continuar:");
            Console.ReadKey();

            Console.WriteLine("Digite o valor da base (b) do triângulo que deseja calcular.");
            double b = double.Parse (Console.ReadLine ());

            Console.WriteLine("Digite o valor da altura (h) do triângulo que deseja calcular.");
            double h = double.Parse (Console.ReadLine ());

            double df = 2; // df = divisão final. 

            Console.WriteLine("A área desse triângulo é: " + b * h / df);
            Console.ReadKey();
        }
    }
}
