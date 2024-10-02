using System;
namespace teste1;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite qualquer palavra");
        string confere = Console.ReadLine();
        string ToLower = confere.ToLower ();
        Console.WriteLine(ToLower);
        int contador = 0;

        foreach (char caractere in ToLower)
        {
            if (caractere == 'a')
            {
                contador++;
            }
        }
        if (contador > 0)
        {
            System.Console.WriteLine($" A string tem {contador} a letra 'a'.");
        }
        else
        {
            System.Console.WriteLine("A string não tem nenhuma letra 'a'.");
        }
    }
}