using System.Globalization;

int A, B, C, D, DIFERENCA;

System.Console.WriteLine("Digite o valor de A: ");
A = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o valor de B: ");
B = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o valor de C: ");
C = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o valor de D: ");
D = int.Parse(Console.ReadLine());


DIFERENCA = (A*B - C*D);

System.Console.WriteLine("Diferença = " + DIFERENCA);
