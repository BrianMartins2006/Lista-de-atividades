using System;

class Program
{
    static int CalcularFatorial(int num)
    {
        int result = 1;

        if (num > 0)
        {
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
        }
        return result;
    }
    static void Main()
    {
        int n,fat;

        Console.WriteLine("Digite o numero que deseja fatorial");
        n = int.Parse(Console.ReadLine());

        fat = CalcularFatorial(n);

      
            Console.WriteLine($"O fatoriade de {n} é: {fat}");
            Console.ReadKey();
    }
}