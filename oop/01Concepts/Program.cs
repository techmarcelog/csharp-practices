using System.Security.AccessControl;
using Classes;
// Instanciar = Criar um objeto a partir de uma classe

// Ex01
Pessoa obj1 = new Pessoa(); // Instanciando a classe Pessoa, criando um objeto do tipo Pessoa
obj1.Nome = "Marcelo";
obj1.Idade = 20;
//obj1.Apresentar();

// Ex02
Pessoa obj2 = new();
obj2.Nome = "Maria";
obj2.Idade = 19;
//obj2.Apresentar();

// Ex03
Pessoa obj3 = new()
{
    Nome = "João",
    Idade = 17
};
string retorno = obj3.VerificarIdade();
Console.WriteLine($"{obj3.Nome} é {retorno}.");