using AssemblyConsole.Entities;
using System.Collections.Generic;

namespace AssemblyConsole.src.statics;
public class TestContato
{
    public static void Master()
    {
        try{
            Console.WriteLine("Digite uma lista de contatos: ");
            Console.Write("Quantos contatos você vai digitar? ");
            var ncontatos = int.Parse(Console.ReadLine());
            Dictionary<string, string> listcontatos = new Dictionary<string, string>();

            for(int i = 0; i < ncontatos; i++)
            {
                Console.Write("Digite o nome do contato: ");             
                var name = Console.ReadLine();
                Console.Write("Digite o email do contato: ");
                var email = Console.ReadLine();
                Console.Write("Digite o etlefone do contato: ");
                int phone = int.Parse(Console.ReadLine());
                Contato contato = new Contato(name, email, phone);
                listcontatos.Add("Email", contato.Email);
            }
            Console.Write("Deseja buscar algum contato? ");
            var resposta = Console.ReadLine();

            if(resposta.Equals("SIM")){

                Console.Write("Email: ");
                listcontatos.Add("Email", Console.ReadLine());
            }

            Console.Write("Deseja buscar um contato específico? ");
            var respd = Console.ReadLine();
            Console.WriteLine("Aqui está a lista de contatos: ");

            foreach(var kvp in listcontatos){
                Console.WriteLine(kvp.Key + kvp.Value);
            }

        }catch(Exception e){
            Console.WriteLine("Ocorreu durante a execução" + e.Message);
        }    
    }
}
