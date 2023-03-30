
Console.WriteLine($"Voce  quer acessar o Programa ??");

Console.WriteLine($"Digite a Senha");
int senha = int.Parse(Console.ReadLine());


if (senha == 1234)
{
    Console.WriteLine($"Acesso Concedido");
    Thread.Sleep(900);
    Console.WriteLine($"Bem - vindo ao Programa ");
}

else 
{
    Console.WriteLine($"Infelizmente voce NAO tem Acesso");
}