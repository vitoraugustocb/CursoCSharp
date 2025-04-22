
string[] valores = Console.ReadLine().Split(' ');
int horaInicial = int.Parse(valores[0]);
int horaFinal = int.Parse (valores[1]);

int duracao;

if (horaInicial < horaFinal){
    duracao = horaFinal - horaInicial;

}

else {
    duracao = 24 - horaInicial + horaFinal;
}



System.Console.WriteLine(" O jogo durou " + duracao +  " HORA(S) ");