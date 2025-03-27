using System;

int valor;
System.Console.WriteLine("Digite um valor: ");
valor = int.Parse(Console.ReadLine());


if (valor < 0 || valor > 100){
    System.Console.WriteLine("Fora do intervalo de valores!");
}