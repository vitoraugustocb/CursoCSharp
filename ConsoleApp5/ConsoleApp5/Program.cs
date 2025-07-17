
using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome completo: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa?");
        int quartos = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o preço do produto: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite na mesma linha seu sobrenome, idade e altura: ");
        string[] vet = Console.ReadLine().Split(' ');
        string sobrenome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

        Console.WriteLine(nome);
        Console.WriteLine(quartos);
        Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine(sobrenome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));
    }
}