double salario, imposto;

System.Console.WriteLine("Digite o valor dos eu salario: ");
salario = double.Parse(Console.ReadLine());

if (salario <= 2000.00){
    System.Console.WriteLine("Isento");
}

else if (salario <= 3000.00){
      imposto = (salario - 2000.00) * 0.08;

    System.Console.WriteLine("Seu Imposto de renda é: " + imposto.ToString("F2"));

}

else if (salario <= 4500.00){
    imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
    System.Console.WriteLine("Seu Imposto de renda é: " + imposto.ToString("F2"));
}

else {

    imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
    System.Console.WriteLine("Seu Imposto de renda é: " + imposto.ToString("F2"));

}