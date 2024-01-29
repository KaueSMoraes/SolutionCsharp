using System.Collections.Generic;
using AssemblyConsole.Entities;
using AssemblyConsole.Entities.Interfaces;

namespace AssemblyConsole.src.statics;
public class TestAccountsList
{
    public static void Master()
    {
        try{
            Console.WriteLine("Você precisa digitar as contas bancárias, para serem armazenadas numa lista:");
            //Lista de QUALQUER Objeto que implementa essa Interface, ou seja, não tem um tipo definido, apenas que a lista de objetos pode ser qualquer um que 
            // Implemente essa interface IContaBancária.
            HashSet<IContaBancaria> contas = new HashSet<IContaBancaria>();

            Console.WriteLine("Digite os dados da primeira conta");

            string resp;
            do
            {  
                Console.Write("Number: "); 
                var number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                var holder = Console.ReadLine();
                Console.Write("Balance: ");
                var balance = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque da conta: ");
                var withdrawlimit = double.Parse(Console.ReadLine());
                System.Console.Write("Conta Poupança: 1 , Conta Corrente 2: ");
                var conta = int.Parse(Console.ReadLine());

                if(conta == 1){
                    contas.Add(new SavingsAccount(number, holder, balance, withdrawlimit, DateTime.Now));
                }else{
                    contas.Add(new AccountCurrent(number, holder, balance, withdrawlimit));
                } 

                Console.WriteLine("Deseja inserir outra conta na lista de contas? ");
                resp = Console.ReadLine();
            
            }while(resp.ToUpper() == "SIM");

            foreach(Account conta in contas){
                Console.WriteLine(conta);
            }
        }catch(Exception e){
            System.Console.WriteLine("Ocorreu um erro durante a execução do programa:  " + e.Message);
        }
    }   
}
