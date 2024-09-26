using System;

class Program
{
    static bool EhPrimo(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        int n;

        Console.WriteLine("Digite um numero para verificar se é primo");
        n = int.Parse(Console.ReadLine());

        bool primo = EhPrimo(n);

        if (primo == true)
        {
            Console.WriteLine($"O numero {n} é primo");
        }
        else
        {
            Console.WriteLine($"O numero {n} não é primo");
        }
        Console.ReadKey();
    }
}