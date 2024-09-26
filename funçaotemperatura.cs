using System;

class Program
{
    static double ConverterParaFahrenheit(double temp) 
    {
        double result;
        result = ((temp * 9 / 5) + 32);
        return result;
    }

    static void Main()
    {
        double temperatura,fa;

        Console.WriteLine("Digite a temperatura para ser convertida");
        temperatura = double.Parse(Console.ReadLine());

         fa = ConverterParaFahrenheit(temperatura);

            Console.WriteLine($"{temperatura:F2} em Fahrenheit é: {fa} ");
            Console.ReadKey();
    }
}