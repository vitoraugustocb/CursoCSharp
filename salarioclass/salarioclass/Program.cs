using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using salarioclass;
using System.Globalization;

Funcionario funcionario1, funcionario2;

funcionario1 = new Funcionario();
funcionario2 = new Funcionario();

Console.WriteLine("Digite o seu nome: ");
funcionario1.nome = Console.ReadLine();

Console.WriteLine("Digite o seu salario: ");
funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite o seu nome: ");
funcionario2.nome = Console.ReadLine();

Console.WriteLine("Digite o seu salario: ");
funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (funcionario1.salario + funcionario2.salario) / 2;

Console.WriteLine("A media dos salarios é: " + media.ToString("F2", CultureInfo.InvariantCulture));