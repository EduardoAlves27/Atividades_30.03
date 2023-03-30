
Console.WriteLine($"Hoje vamos ver Qual tipo de triangulo voce esta vendo");

Console.WriteLine($"Informe aqui o valor de um dos lados deste triangulo");
float ld1 = float.Parse(Console.ReadLine());

Console.WriteLine($"informe o valor do lado 2");
float ld2 = float.Parse(Console.ReadLine());

Console.WriteLine($"informe o valor do lado 3");
float ld3 = float.Parse(Console.ReadLine());

if ((ld1 == ld2) && (ld2 == ld3))
{
    Console.WriteLine($"Este Triangulo e Equilatero");  
}

else if ((ld1 == ld2) && (ld2 != ld3) || (ld1 == ld3) && (ld3 != ld2) || (ld2 == ld3) && (ld1 != ld3))
{
    Console.WriteLine($"Este triangulo e isoceles");
}

else 
{
    Console.WriteLine($"Este triangulo e escaleno"); 
}