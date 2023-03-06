//[M1S01] Ex 2 - Organizador de lista de frutas
//Crie um programa que receba do usuário uma lista de frutas com no máximo 15 itens.
//Organize as frutas em ordem alfabética e exiba a lista.

List<string> frutas = new List<string>();

for (int i = 0; i < 15; i++)
{   
    Console.WriteLine("Digite o nome de uma fruta: ");
    frutas.Add(Console.ReadLine());
    Console.WriteLine("Deseja continuar? (S - sim; N - não)  ");
    string resposta = Console.ReadLine();

    if (resposta == "nao" || resposta == "n")
    {
        break;
    }
}

frutas.Sort();

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}