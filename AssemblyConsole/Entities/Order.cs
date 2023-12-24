using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using AssemblyConsole.Entities.Enums;

namespace AssemblyConsole.Entities;
public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> OrderItens { get; set; }
    public Client OrderClient { get; set; }

    //Construtor Padrão sem Sobrecarga
    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        OrderClient = client;
        OrderItens = new List<OrderItem>();
    }

    public Order()
    {
    }

    //Métodos padrões de Adição e Remoção de Itens
    public void AddItem(OrderItem item)
    {
        OrderItens.Add(item);
    }
    public void RemoveItem(OrderItem item)
    {
        OrderItens.Remove(item);
    }

    public double Total()
    {
        double saldo = 0.0;
        foreach(OrderItem item in OrderItens)
        {
            saldo += item.SubTotal();
        }
        return saldo;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("ORDER SUMARY: ");
        sb.AppendLine("Moment: " + Moment.ToString("dd/MM/yyyy"));
        sb.AppendLine("Order Status: " + Status);
        sb.AppendLine("Client: " + OrderClient);
        sb.AppendLine("Order Items: ");

        foreach(OrderItem item in OrderItens)
        {
            sb.AppendLine(item.ToString());
        }
        
        sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
        return sb.ToString();
    }
}
