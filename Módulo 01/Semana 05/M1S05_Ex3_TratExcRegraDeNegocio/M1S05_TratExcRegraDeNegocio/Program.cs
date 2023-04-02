using M1S05_TratExcRegraDeNegocio;

try
{
    Evento evento = new Evento();
    evento.QtdIngressosVendidos = 15;
    evento.QtdLugares = 16;

    if (evento.QtdLugares - evento.QtdIngressosVendidos > 0)
    {
        Console.WriteLine("Ingresso validado!");
        evento.ingressoVendido();
    }
    else
    {
        throw new IngressoException("Não esistem mais lugares disponíveis para o evento!");
    }
}
catch (IngressoException ex)
{
    Console.WriteLine(ex.Message);
}
