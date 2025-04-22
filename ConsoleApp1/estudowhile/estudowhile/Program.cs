internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite uma senha de 4 numeros: ");
        int senha = int.Parse(Console.ReadLine());
        while (senha != 2002){
            System.Console.WriteLine("Senha incorreta!");
            System.Console.WriteLine("Digite novamente uma senha: ");
            senha = int.Parse(Console.ReadLine());

        }
        System.Console.WriteLine("Senha correta!");
    }
}