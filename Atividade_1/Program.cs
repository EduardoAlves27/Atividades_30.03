
Console.WriteLine($"Hoje iremos avaliar seu orçamento.");

Console.WriteLine($"Nos informe seu salario.");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"nos infome agora qual foi o vaolor gasto durante este mes");
float gastos =float.Parse(Console.ReadLine());

if (salario > gastos)
{
    Console.WriteLine($"Gastos dentro do orcamento");
}

else
{
    Console.WriteLine($"Orcamento estourado");  
}