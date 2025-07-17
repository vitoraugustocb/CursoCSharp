using System.Globalization;
using System;

internal class Program

{

    private static void Main(string[] args)
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de Escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;


        Console.WriteLine("Produtos: \n {0}, cujo o preço é ${1} \n {2}, cujo o preço é {3}", produto1, preco1.ToString("F2"), produto2, preco2.ToString("F2"));

        Console.WriteLine("Registro: {0} de idade, código {1} e gênero: {2}", idade, codigo, genero);

        Console.WriteLine("Medida com oito casas decimais: {0}\n Arredondado (com três casas decimais): {1}\n Separador decimal com invariant culture: {2} ", medida.ToString("F8"), medida.ToString("F3"), medida.ToString("F3",CultureInfo.InvariantCulture));
    }
}