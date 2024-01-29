using System.Globalization;
using AssemblyConsole.Entities.Exceptions;
using AssemblyConsole.Entities.Interfaces;

namespace AssemblyConsole.Entities;

public abstract class Account 
{
    public int Number { get; private set; }
    public string Holder { get; set; }
    public double  Balance { get; set; }
    public double WithdrawLimit { get; set; }

    //Constrói a classe 
    public Account(int number, string holder, double balance, double withdrawlimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawlimit;
    }
    //Utilizo lançamento de exceções para dar mais legibilidade no código e controle de possíveis +
    //Exceções na aplicação(método main())
    public void withdraw(double amount)
    {
        if (amount > Balance){

           throw new AppException1("SALDO INSUFICIENTE PARA SAQUE EM CONTA CORRENTE");

        }else if (amount > WithdrawLimit){

           throw new AppException1("LIMITE DE SAQUE DIÁRIO EXCEDIDO EM CONTA");

        }else{
            Balance -= amount;
        }
    }

    public override string ToString()
    {
        return "Saldo conta atualizado: " +
        Balance.ToString("F2", CultureInfo.InvariantCulture);
    }
}
