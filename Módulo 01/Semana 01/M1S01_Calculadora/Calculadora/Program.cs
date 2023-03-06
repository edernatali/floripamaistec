// Importação de bibliotecas 

// Nome da classe

// Declaração de método

// Declaração de variáveis
int opcao, numero1=0, numero2=0;
float resultado=0;
int resto;

// Entradas
Console.WriteLine("Escolha uma operação: \n\n" +
    "1 - soma\n2 - subtração\n3 - multiplicação\n4 - divisão\n\n" +
    "5 - sair\n\nDigite a opção escolhida: ");

opcao = int.Parse(Console.ReadLine());

// Processamento
switch(opcao)
{
    // Bloco de instruções da estrutura condicional
    case 1:
        Console.WriteLine("Operação somar.");
        Console.WriteLine("Digite o numero 1: ");
        numero1 = int.Parse(Console.ReadLine());    
        Console.WriteLine("Digite o número 2: ");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 + numero2;
        break;
    case 2:
        Console.WriteLine("Operação subtrair.");
        Console.WriteLine("Digite o numero 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número 2: ");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 - numero2;
        break;
    case 3:
        Console.WriteLine("Operação multiplicação.");
        Console.WriteLine("Digite o numero 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número 2: ");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 * numero2;
        break;
    case 4:
        Console.WriteLine("Operação divisão.");
        Console.WriteLine("Digite o numero 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número 2: ");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 / numero2;
        resto= numero1 % numero2;
        Console.WriteLine("O resto da divisão é: " + resto);
        break;
    case 5:
        Console.WriteLine("Saindo do sistema.");
        break;

}
Console.WriteLine("O resultado é: " + resultado);


// Saídas