class Pessoa : Acoes
{
    // Métodos obrigatórios de serem implementados assim que classe Pessoa herda Classe Acoes
    public override void Andar()
    {
        Console.WriteLine("Andando..");
    }

    public override void Falar()
    {
        Console.WriteLine("Falando..");
    }
}