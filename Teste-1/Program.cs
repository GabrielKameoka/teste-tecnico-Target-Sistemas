using System;
namespace teste1;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite um número");
        int numero = int.Parse(Console.ReadLine());

        if (Pertencente(numero))
        {
            System.Console.WriteLine($"O {numero} pertence a sequencia de Fibonaci");
        }
        else
        {
            System.Console.WriteLine($"O {numero} não pertence a sequencia de Fibonaci.");
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Entre com qualquer tecla para sair");
        Console.ReadLine();
    }
    static bool Pertencente(int num)
    {
        int a = 0;
        int b = 1;
        while (b <= num)
        {
            if (b == num)
                return true;

            int temporario = b;
            b = a + b;
            a = temporario;
        }
        return false;
    }
}