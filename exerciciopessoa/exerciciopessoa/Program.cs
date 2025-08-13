using System.Threading.Channels;
using exerciciopessoa;

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();

Console.WriteLine("Qual o seu nome? ");

pessoa1.nome = Console.ReadLine();

Console.WriteLine("Qual a sua idade? ");

pessoa1.idade = int.Parse(Console.ReadLine());


Console.WriteLine("Qual o seu nome? ");

pessoa2.nome = Console.ReadLine();

Console.WriteLine("Qual a sua idade? ");

pessoa2.idade = int.Parse(Console.ReadLine());


if (pessoa2.idade > pessoa1.idade)
{
    Console.WriteLine("A pessoa mais velha é " + pessoa2.nome);
}
else
{
    Console.WriteLine("A pessoa mais velha é " + pessoa1.nome);
}