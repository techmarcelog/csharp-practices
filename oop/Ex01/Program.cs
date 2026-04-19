// Sistema de conta bancária.
// --------------------------

using Classes;

ContaBancaria objCC1 = new ContaBancaria("Marcelo", "23141241421", 5000);
Console.WriteLine(objCC1.Saldo);
objCC1.Depositar(200);
Console.WriteLine(objCC1.Saldo);
objCC1.Sacar(3000);
