namespace AssemblyConsole.Entities.Interfaces;

public interface IContaBancaria
{
    public double DepositarValor(double amount);
    public double SacarValor(double amount);
    public double ConsultarSaldo();

}
