//int a = 10;
//bool c1 = a < 10;
//bool c2 = a < 20;
//System.Console.WriteLine(c1);
//System.Console.WriteLine(c2);
// precedência do && maior que a precedência de ||

System.Console.WriteLine("Que horas são?");
int hora = int.Parse(Console.ReadLine());

if (hora <= 12){
    System.Console.WriteLine("Bom dia!");
}
else if (hora > 12 && hora < 18){
    System.Console.WriteLine("Boa tarde!");
}
else 
System.Console.WriteLine("Boa noite!");