using System;
using System.Globalization;


System.Console.WriteLine("Digite um valor: ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


if (valor < 0 || valor > 100){
    System.Console.WriteLine("Fora do intervalo de valores!");
}

else if (valor >= 0 && valor <= 25){
    System.Console.WriteLine("Intervalo entre 0 e 25");
}

else if (valor >= 25 && valor <= 50){
    System.Console.WriteLine("Intervalo entre 25 e 50");
}

else if (valor >= 50 && valor <= 75){
    System.Console.WriteLine("Intervalo entre 50 e 75");
}
else if (valor >= 75 && valor <= 100){
    System.Console.WriteLine("Intervalo entre 75 e 100");
}