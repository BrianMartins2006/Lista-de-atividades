using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro texto:");
        string texto1 = Console.ReadLine();

        Console.WriteLine("Digite o segundo texto:");
        string texto2 = Console.ReadLine();

        bool saoIguais = string.Compare(texto1.ToUpper(), texto2.ToUpper()) == 0;
        Console.WriteLine("Os textos são iguais? " + saoIguais);

        Console.WriteLine("Quantidade de caracteres no primeiro texto: " + texto1.Length);
        Console.WriteLine("Quantidade de caracteres no segundo texto: " + texto2.Length);
    }
}
