Console.Clear();

Console.WriteLine("---Super comparador de abastecimento---");

Console.WriteLine("Digite o valor do Alcool: ");
    decimal alcool = Convert.ToDecimal(Console.ReadLine()!);

Console.WriteLine("Digite o valor da Gasolina: ");
    decimal gasolina = Convert.ToDecimal(Console.ReadLine()!);

    decimal razao = CalcularRazao(alcool, gasolina);
    decimal percentual = razao * 100;

Console.WriteLine($"\nOpreço do álcool corresponde a {percentual:F1}% do preço da gasolina.");

if (ValeAPenaGasolina(razao))
    Console.WriteLine("\nRecomendação: Abasteça com Gasolina amigo!");
else
    Console.WriteLine("\nRecomendação: Abasteça com Álcool amigo!");

decimal CalcularRazao(decimal alcool, decimal gasolina)
{
    return alcool / gasolina;
}

bool ValeAPenaGasolina(decimal razao)
{
    return razao > 0.73m;
}