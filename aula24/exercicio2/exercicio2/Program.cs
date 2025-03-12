
//Exercicio2)
//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
//casas decimais conforme exemplos.
//Fórmula da área: area = π . raio2
//Considere o valor de π = 3.14159

using System;
using System.Formats.Asn1;
using System.Globalization;


double pi = 3.14159, raio, area;

Console.WriteLine("Digite o valor do raio: ");
raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

area = pi * (raio * 2);

System.Console.WriteLine("O valor da area é de: " + area.ToString("F4"));