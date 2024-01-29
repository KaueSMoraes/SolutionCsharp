using AssemblyConsole.Entities.Interfaces;


namespace AssemblyConsole.Entities;

public class SavingsAccount : Account, IContaBancaria
{
    public DateTime DCreateAccount { get; private set; }
    //Constrói classe da conta baseada na Conta Principal
    public SavingsAccount(int number, string holder, double balance, double withdrawlimit, DateTime date) :base(number, holder, balance, withdrawlimit)
    {
        DCreateAccount = date;
    }
    public double DepositarValor(double amount)
    {
        return Balance += amount;
    }
    public double SacarValor(double amount)
    {
        double tax = CalTaxJuros();
        return Balance -= (amount * tax);
    }
    public double ConsultarSaldo()
    {
        return Balance;
    }

    private double CalTaxJuros()
    {   
        TimeSpan interval = DateTime.Now - DCreateAccount;
        if(interval.TotalDays > 30 ){
            return 2.0;
        }else{
            return 1.0;
        }
    }
}


