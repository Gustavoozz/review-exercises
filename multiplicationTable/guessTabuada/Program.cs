Console.WriteLine("Informe um número:");
float tabuada = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Tabuada do número: {tabuada}");
Console.WriteLine($"=================================");
for (int n = 1; n <= 10 ; n++)
{
Console.WriteLine($"{tabuada} X {n} = " + tabuada * n);  
}
Console.WriteLine($"=================================");