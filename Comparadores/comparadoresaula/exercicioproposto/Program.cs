
using System;
using System.Security.AccessControl;

int op;
double preco = 0 , pagar = 0, quantidade;

System.Console.WriteLine("Bem vindo ao Jeffinho lanches!");
System.Console.WriteLine("Escolha sua opção:\n 1) Cachorro Quente - R$ 4.00\n 2) X-Salada - R$ 4.50\n 3) X-Bacon - 5.00 \n 4) Torrada Simples - R$ 2.00\n 5) Refrigerante - R$ 1.50");

op = int.Parse(Console.ReadLine());

if (op == 1){
     preco = 4.00;
}
else if (op == 2){
    preco = 4.50;    
}
else if (op == 3){
    preco = 5.00;
}
else if (op == 4){
    preco = 2.00;
}
else if (op == 5 ){
    preco = 1.50;
}
else {
    System.Console.WriteLine("Opção invalida!");
    
}

if (op >= 1 && op <= 5){
    System.Console.WriteLine("Qual quantidade deseja comprar?");
    quantidade = double.Parse(Console.ReadLine());
    pagar = preco * quantidade;
    System.Console.WriteLine("O valor a pagar é: " + pagar.ToString("F2"));

}

