Console.WriteLine("Informe a nota do aluno:");
float nota = float.Parse(Console.ReadLine()!);

if (nota > 3) {
    Console.WriteLine("O aluno está reprovado!");
} else if ( nota > 4 && nota < 5) {
    Console.WriteLine("O aluno está de recuperação!");
} else {
    Console.WriteLine("O aluno está aprovado!");
};



