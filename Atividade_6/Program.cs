// ter a frequencia do aluno e a nota 

// caso ela for maior que 75 avaliar a nota 
// caso for maior igual a 3 ou menor que 7 esta de recuperacao  
 
// caso for menor que 75 ja esta reprovado 

Console.WriteLine($"Vamos ver a condição do aluno");

Console.WriteLine($"Digite a nota do aluno");
float nota = float.Parse(Console.ReadLine());

Console.WriteLine($"Agora Insira a frequencia dele em porcentagem");
float freq = float.Parse(Console.ReadLine());


if (freq < 75 || nota < 3)
{
    Console.WriteLine($"O aluno ja esta REPROVADO");
    
}

else if ( freq >= 75 && nota >= 7 )

{
    Console.WriteLine($"O Aluno Esta APROVADO.... CONGRATULATIONS");
    
}

else 
{
    Console.WriteLine($"O Aluno esta de RECUPERACAO");
    
}
