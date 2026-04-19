namespace Classes;
class Pessoa // Classe
{
    // Atributos, características, propriedades
    public string? Nome;
    public int Idade;

    // Método de apresentação
    public void Apresentar()
    {
    Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }

    // Método para retornar idade

    public string VerificarIdade()
    {
        return Idade >= 18 ? "Maior de idade" : "Menor de idade";
    }    
}