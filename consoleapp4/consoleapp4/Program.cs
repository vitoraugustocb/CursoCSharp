using System.Globalization;
using System.Runtime.CompilerServices;

string nome = "Vitor";
int idade = 29;
double saldo = 23.2984539;

Console.WriteLine(saldo);
Console.WriteLine(saldo.ToString("F2"));
Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));


Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));