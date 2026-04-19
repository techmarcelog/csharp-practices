namespace Classes;
class ContaBancaria
{
    public string Titular {get; private set;}
    public string NumeroConta {get; private set;}
    public decimal Saldo {get; private set;}

    public ContaBancaria(string titular, string numeroConta, decimal saldoInicial)
    {
        if(string.IsNullOrWhiteSpace(titular))
        {
            throw new ArgumentException("Titular Inválido.");
        }
        if(string.IsNullOrWhiteSpace(numeroConta))
        {
            throw new ArgumentException("Número da conta inválido.");
        }
        if(saldoInicial <= 0)
        {
            throw new ArgumentException("Saldo inicial não pode ser menor ou igual a 0");
        }

        Titular = titular;
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        if (valor < 0)
        {
            throw new ArgumentException("O valor deve ser maior que zero");
        }
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if(valor > Saldo)
        {
            throw new InvalidOperationException("Não é possivel sacar um valor maior que o saldo atual da conta.");
        }

        Saldo -= valor;
    }
}