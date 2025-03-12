using System.Globalization;
using System;

Console.WriteLine("Digite seu nome completo:");
string nome = Console.ReadLine(); 

Console.WriteLine("Quantos quartos tem na sua casa?");
int quartos = int.Parse(Console.ReadLine());

System.Console.WriteLine("Entre com o preço do produto: "); 
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre seu ultimo nome, idade e altura: ");
string[] vet = Console.ReadLine().Split(' ');
string nome1 = vet [0];
int quartos1 = int.Parse(vet[1]);
double preco1 = double.Parse(vet[2], CultureInfo.InvariantCulture);


System.Console.WriteLine(nome);
System.Console.WriteLine(quartos);
System.Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
System.Console.WriteLine(nome1);
System.Console.WriteLine(quartos1);
System.Console.WriteLine(preco1.ToString("F2", CultureInfo.InvariantCulture));