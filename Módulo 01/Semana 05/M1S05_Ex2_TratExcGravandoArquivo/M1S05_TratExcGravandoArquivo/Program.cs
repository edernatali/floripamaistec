FileInfo arquivo = null;

try // zona segura
{
    Console.Write("Digite o nome do arquivo que você vai criar: ");
    string nomeArquivo = Console.ReadLine();

    arquivo = new FileInfo(nomeArquivo);

    using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
    {
        gravadorFluxo.WriteLine("Texto de dentro do arquivo.");
    }
}

catch (ArgumentException ex)
{
    Console.WriteLine($"Tratando o erro expecificamente: {ex}");
}

catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex}");
}

finally
{
    Console.WriteLine($"Encerrando o programa ... \n");
    //arquivo = null;
    //Console.Clear();
 }


