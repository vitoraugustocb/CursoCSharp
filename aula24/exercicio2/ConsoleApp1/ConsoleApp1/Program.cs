// Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
//mostre:  
//a) a área do triângulo retângulo que tem A por base e C por altura.  
//b) a área do círculo de raio C. (pi = 3.14159)  
//c) a área do trapézio que tem A e B por bases e C por altura.  
//d) a área do quadrado que tem lado B.  
//e) a área do retângulo que tem lados A e B.


using System.Globalization;
using System.Xml;

double A, B, C;
double pi = 3.14159; 

System.Console.WriteLine("Digite o valor de A: ");
A = double.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o valor de B: ");
B = double.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o Valor de C: ");
C = double.Parse(Console.ReadLine());


double areatri = A * C / 2;

double circulo = pi * C * C;

double areatra = (A+B) * C /2;

double areaqua = B * B;

double areare = A * B;

System.Console.WriteLine("TRIANGULO: " + areatri.ToString("F3"));
System.Console.WriteLine("CIRCULO: "+ circulo.ToString("F3"));
System.Console.WriteLine("AREA TRAPEZIO: " +areatra.ToString("F3"));
System.Console.WriteLine("AREA QUADRADO: " +areaqua.ToString("F3"));
System.Console.WriteLine("AREA RETÂNGULO: " +areare.ToString("F3"));







