class Pessoa
{
    // Atributos
    private string? _nome;
    private int _idade;
    private double _altura;

    // Construtor
    public Pessoa(string nome, int idade, double altura)
    {
        _nome = nome;
        _idade = idade;
        _altura = altura;
    }
    // Método para apresentar os dados
    protected void ApresentarPessoa()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine($"Idade: {_idade}");
    }
}