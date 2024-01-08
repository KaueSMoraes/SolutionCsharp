using AssemblyConsole.Entities;
using AssemblyConsole.Entities.Exceptions;

namespace AssemblyConsole.src;

public static class TestExceptions
{
    public static void Master()
    {
        try{    
            System.Console.WriteLine("Enter account data: ");
            System.Console.Write("Number: ");
            int numberAccount = int.Parse(Console.ReadLine());
            System.Console.Write("Holder: ");
            string holder = Console.ReadLine();
            System.Console.Write("Initial Balance: ");
            double iniBalance = double.Parse(Console.ReadLine());
            System.Console.Write("Withdraw limit: ");
            double withdrawlimit = double.Parse(Console.ReadLine());

            Account acc = new Account(numberAccount, holder,iniBalance, withdrawlimit );

            System.Console.Write("Enter amount for Withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            acc.withdraw(amount);
            System.Console.WriteLine(acc);

        }catch(AppException1 e){
            System.Console.WriteLine("Error Application:" + e.Message);

        }catch(Exception e ){
            System.Console.WriteLine("System Error: " + e.Message);
        }
    }
}
