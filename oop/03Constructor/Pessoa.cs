class Pessoa
{
    // 1º Construtor

    public Pessoa()
    {
        Console.WriteLine("(Construtor 1)");
    }

    // 2º Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome} (Construtor 2)");
    }
   
   // 3º Construtor
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Olá {nome}, você tem {idade} anos (Construtor 3)");
    }
}