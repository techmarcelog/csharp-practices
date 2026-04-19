class Colaborador : Pessoa // Colaborador herda todas as características de Pessoa
{
    // Atributos
    private string? _cargo;
    private double _salario;

    // Construtor
    public Colaborador(string nome, int idade, string cargo, double salario, double altura) : base (nome, idade, altura)
    {
        _cargo = cargo;
        _salario = salario;

        ApresentarPessoa();
        ApresentarColaborador();
    }

    // Método para apresentar os dados
    private void ApresentarColaborador()
    {
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"Salário: {_salario}");
    }
}