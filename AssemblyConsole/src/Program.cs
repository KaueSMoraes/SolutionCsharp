using AssemblyConsole.src.statics;   
using AssemblyConsole.src;
using Microsoft.VisualBasic;

namespace AssemblyConsole;
public class Program()
{
    public static void Main(string[]args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bem Vindo ao Programa de Console e treinamento de POO de Kauê Santos de Moraes");
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.Write("Escreva o nome da funcionalidade de console que você deseja executar: ");
        var classe = Console.ReadLine();
       
        switch (classe)
        {
            case "TestOrder":
                TestOrder.Master();
            break;

            case "TestProducts":
                TestProducts.Master();
            break;

            case "TestExceptions":
                TestExceptions.Master();
            break;    

            case "TesteAccountList":
                TestAccountsList.Master();
            break;

            case "TestContato":
                TestContato.Master();
            break;     
        }
        Console.WriteLine("Pressione Enter para finalizar o programa...");
        Console.ReadLine();
    }
}