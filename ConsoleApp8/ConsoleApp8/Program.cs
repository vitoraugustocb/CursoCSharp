Console.WriteLine("Digite um numero: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Você digitou o numero: {0}, seus numeros impares são: ", numero);
for (int i = 1; i <= numero; i++)
{
    
    if (i % 2 != 0)
    {
       
        Console.WriteLine(i);
    }
}
