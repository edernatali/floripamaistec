try
{
    Console.WriteLine("Calcule a divisão entre dois números inteiros");
    Console.Write("Digite o numerador: ");
    decimal numero1 = decimal.Parse(Console.ReadLine());

    Console.Write("Digite o denominador: ");
    decimal numero2 = decimal.Parse(Console.ReadLine());

    decimal resultado = numero1 / numero2;
    Console.WriteLine($"O resultado de {numero1} divido por {numero2} é: {resultado}");
}

catch (DivideByZeroException ex)
{
    Console.WriteLine($"O denominador informado não pode ser zero, informe outro número.");
}

catch (FormatException ex)
{
    Console.WriteLine($"O formato de número informado é inválido, informe outro número.");
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

finally
{
    decimal numero1 = 0;
    decimal numero2 = 0;
}