
Console.WriteLine($"Hoje analisaremos o placar do Jogo");

Console.WriteLine($"Infome o placar do jogo, mas somente os pontos do time 1");
int tm1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Infome somente os pontos do time 2");
int tm2 = int.Parse(Console.ReadLine());

if (tm1 == tm2)
{
    Console.WriteLine($"Houve Empate entre os times.");
    
}

else if (tm1 > tm2)
{
    Console.WriteLine($"Hoje a vitoria foi do Time 1");
    
}

else 
{
    Console.WriteLine($"Hoje a Vitoria foi do Time 2");
    
}

