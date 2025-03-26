//int a = 10;
//bool c1 = a < 10;
//bool c2 = a < 20;
//System.Console.WriteLine(c1);
//System.Console.WriteLine(c2);
// precedência do && maior que a precedência de ||

System.Console.WriteLine("Digite um numero inteiro: ");
int x = int.Parse(Console.ReadLine());

if (x % 2 == 0)
    {
        System.Console.WriteLine("O seu numero é par!");

    }
else {
    System.Console.WriteLine("Esse numero é impar!");
}