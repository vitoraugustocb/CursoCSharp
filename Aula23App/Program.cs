
using System.Globalization; // Biblioteca para utilizar o CultureInfo


    int n1 = int.Parse(Console.ReadLine());       // Converte a leitura de string do Console.Readline para um inteiro com o comando .Parse
    char ch = char.Parse(Console.ReadLine());     // Converte a leitura de string do Console.Readline para um char com o comando .Parse
    double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // CultureInfo.InvariantCulture serve para que o programa aceite o ponto como separador de casas decimais

    string[] vet = Console.ReadLine().Split(' ');
    string nome = vet [0];
    char sexo = char.Parse(vet[1]);
    int idade = int.Parse(vet[2]);
    double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


    Console.WriteLine("Você digitou:");
    Console.WriteLine(n1);
    Console.WriteLine(ch);
    Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture)); // CultureInfo.InvariantCulture serve para que o programa aceite o ponto como separador de casas decimais
    Console.WriteLine(nome);
    Console.WriteLine(sexo);
    Console.WriteLine(idade);
    Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));