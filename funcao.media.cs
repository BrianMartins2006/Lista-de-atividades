using System;

class Program
{
    static float Media(float num1, float num2, float num3)
    {
        float resultado;
        resultado = (num1 + num2 + num3) / 3;
        return resultado;
    }
    static void Main()
    {
        float n1, n2, n3, resultado;
        Console.WriteLine("Digite três valores");
        n1 = float.Parse(Console.ReadLine());
        n2 = float.Parse(Console.ReadLine());
        n3 = float.Parse(Console.ReadLine());

        resultado = Media(n1, n2, n3);

        Console.WriteLine("media: " + resultado);
        Console.ReadKey();
    }
}