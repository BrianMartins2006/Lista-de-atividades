﻿using System;

class Program
{
    static double CalcularPotencia(double baseN, double expoente)
    {
        double result;
        result = (double)Math.Pow(baseN, expoente);
        return result;
    }
    static void Main()
    {
        double basenum,expoente,pot;

        Console.WriteLine("Informe a base: ");
        basenum = Double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o expoente: ");
        expoente = Double.Parse(Console.ReadLine());

        pot = CalcularPotencia(basenum,expoente);

        Console.WriteLine($"A potencia de {basenum} elevado a {expoente} é: {pot}");
        Console.ReadKey();
    }
}