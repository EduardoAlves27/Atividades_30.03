
Console.WriteLine($"Quantas maçãs voce quer comprar");
Thread.Sleep(900);
Console.WriteLine($"Aviso caso compre menos do que 12 elas saem poer 0,30 centavos, porem caso compre 12 ou mais elas saem a 0,25 centavos");
int maca = int.Parse(Console.ReadLine());
float valor;

Thread.Sleep(1500);
if( maca >= 12) 

{
    valor = maca* 0.25f;
    Console.WriteLine($"todas estas maçãs saem por R${valor}");
}

else 

{
    valor = maca*0.30f;
    Console.WriteLine($"todas estas maçãs saem por R${valor}");
}


