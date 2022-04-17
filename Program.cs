double numerador, denominador, resultadoDivisao;

Console.Write("Digite o numerador....:");
numerador = Convert.ToDouble (Console.ReadLine());

Console.Write("Digite o denominador..:");
denominador = Convert.ToDouble (Console.ReadLine());

if ( denominador == 0)
{
    Console.WriteLine("Não é possível dividir por zero.");
}

else  
{
    resultadoDivisao = numerador / denominador ;
    Console.WriteLine($"{numerador:N1} divido por {denominador:N1} é {resultadoDivisao:N1}");
}