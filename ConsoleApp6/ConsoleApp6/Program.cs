// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;



Console.WriteLine("Digite um numero: ");
float numero = float.Parse(Console.ReadLine());

if (numero > 0 && numero <= 25)
{
    Console.WriteLine("Está nos intervalos (0,25");
}
else if (numero > 25 && numero <= 50)
{
    Console.WriteLine("Está nos intervalos (25,50)");
}
else if (numero > 50 && numero <= 75)
{
    Console.WriteLine("Está nos intervarlos (50,75");
}
else if (numero >75 && numero <= 100)
{
    Console.WriteLine("Está nos intervalos (75,100)");
}
else
{
    Console.WriteLine("Fora dos intervalos!");
}