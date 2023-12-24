using System.Runtime.CompilerServices;
using AssemblyConsole.Entities;
using AssemblyConsole.Entities.Enums;

namespace AssemblyConsole.src;

abstract class TestOrder
{
    public static void Master()
    {
        System.Console.WriteLine("Enter Cliente Data: ");
        System.Console.Write("Name: ");
        var name = Console.ReadLine();
        System.Console.Write("Email: ");
        var email = Console.ReadLine();
        System.Console.Write("Birth Date: ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        Client client = new Client(name, email, birthdate);

        //Crio nova Instância do Objeto Pedido. Variável = Order        
        Console.WriteLine("Enter Order Data: ");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
        Order order = new(DateTime.Now, status, client);

        //Adiciono novas instâncias do Objeto Item, na lita do Objeto Pedido.
        Console.Write("How many items to this order? ");
        var n = int.Parse(Console.ReadLine());

        for(int i =0; i < n; i++)
        {
            Console.WriteLine("Enter #" + n + "item data: ");
            Console.Write("Product Name: ");
            var nameproduct = Console.ReadLine();         
            Console.Write("Product Price: "); 
            var priceproduct = double.Parse(Console.ReadLine());
            Console.Write("Quantity: "); 
            var quantity = int.Parse(Console.ReadLine());
            //Instacio o Objeto de Produto com os dados inseridos
            Product product = new(nameproduct, priceproduct);
            OrderItem item = new(quantity, priceproduct, product);

            //Adiciono na lista, o Obejeto Item
            order.AddItem(item);
        }

        System.Console.WriteLine("-----------------------------------------");
        System.Console.WriteLine(order);
    }
}
