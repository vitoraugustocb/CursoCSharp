// See https://aka.ms/new-console-template for more information


string frase = Console.ReadLine();

string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();

string s = Console.ReadLine();

string[] v = s.Split(' '); // Apagar a variável s = Console.ReadLine(); e simplificar para uma váriavel Console.ReadLine().Split(' ');
string a = v[0];   
string b = v[1];
string c = v[2];

System.Console.WriteLine("Você digitou: " + frase);
System.Console.WriteLine(x);
System.Console.WriteLine(y);   
System.Console.WriteLine(z);
System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);

string[] vet = s.Split(' ');  // Split é um método que separa uma string em várias partes, de acordo com um delimitador
string p1 = vet[0];
string p2 = vet[1];
string p3 = vet[2];