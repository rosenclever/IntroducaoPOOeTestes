// See https://aka.ms/new-console-template for more information
using Financeiro.Model;

Conta conta1 = new Conta(123456, 10);
Conta conta2 = new Conta(654321);
Console.WriteLine($"A conta número {conta1.Numero} possui saldo {conta1.Saldo}");
Console.WriteLine($"A conta número {conta2.Numero} possui saldo {conta2.Saldo}");