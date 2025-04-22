using System.Formats.Asn1;

internal class Program
{
    private static void Main(string[] args)
    {
       System.Console.WriteLine("Digite o valor de X: ");
       int x = int.Parse(Console.ReadLine());
       System.Console.WriteLine("Digite o valor de Y: ");
       int y = int.Parse(Console.ReadLine());
       
       while (x != 0 && y != 0){
        
        if (x > 0 && y > 0){
            System.Console.WriteLine("Primeiro quadrante do plano cartesiano");
        }
        else if (x < 0 && y  > 0){
            System.Console.WriteLine("Segundo quadrante do plano cartesiano");
        }
        else if (x < 0 && y < 0){
            System.Console.WriteLine("Terceiro quadrante do plano cartesiano");
        }
       
        else {
            System.Console.WriteLine("Quarto quadrante do plano cartesiano");
        }

       System.Console.WriteLine("Digite o valor de X: ");
        x = int.Parse(Console.ReadLine());
       System.Console.WriteLine("Digite o valor de Y: ");
        y = int.Parse(Console.ReadLine());
        
    
       }
       
    }
}