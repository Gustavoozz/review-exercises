Random randNum = new Random();
int numRandom = randNum.Next(0, 100);
int num;
int tryNumb = 0;

do
{
    Console.WriteLine("Advinhe o número aleatório:");
    num = int.Parse(Console.ReadLine()!);
    tryNumb++;
    
    if (num < numRandom)
    {
        Console.WriteLine($"O número digitado é menor. Tente novamente!");
        
    } else if (num > numRandom)
    {
        Console.WriteLine($"O número digitado é maior. Tente novamente!");
    } 
    else {
        Console.WriteLine("Parabens! Voce acertou! O número era: " + numRandom);
        
    }

    
} while (num != numRandom);

Console.WriteLine($"Número de tentativas: " + tryNumb);
