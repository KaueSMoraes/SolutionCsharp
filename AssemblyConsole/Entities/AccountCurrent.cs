using System.Security.Cryptography.X509Certificates;
using AssemblyConsole.Entities.Interfaces;
using AssemblyConsole.Entities.Exceptions; 

namespace AssemblyConsole.Entities;

public class AccountCurrent : Account, IContaBancaria
{
    public AccountCurrent(int number, string holder, double balance, double withdrawlimit ) : base(number, holder, balance, withdrawlimit){}
    public double DepositarValor(double amount)
    {
        return Balance += amount;
    }

    public double SacarValor(double amount)
    {
        return Balance -= amount;
    }
    public double ConsultarSaldo()
    {
        return Balance;
    }
}


