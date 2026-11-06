
Console.WriteLine("-- Média ---");



Console.WriteLine("Digite as suas notas abaixo.");



Console.Write("Nota 1: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 2: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 3: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 4: ");
double nota4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

if (nota1 < 0 || nota1 > 10 ||
    nota2 < 0 || nota2 > 10 ||
    nota3 < 0 || nota3 > 10 ||
    nota4 < 0 || nota4 > 10)
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}
else
{
    double media = (nota1 + nota2 + nota3 + nota4) / 4;
    string resultado;

    if (media < 5)
    {
        resultado = "Reprovado";
    }
    else if (media < 7)
    {
        resultado = "Em recuperação";
    }
    else
    {
        resultado = "Aprovado";
    }

    Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultado}");
}