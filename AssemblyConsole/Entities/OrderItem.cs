using System.Net.Http.Headers;

namespace AssemblyConsole.Entities;
public class OrderItem
{
    public int Quantity { get; private set; }
    public double Price { get; private set; }
    public Product OrderProduct {get; private set;}

    //Construtor padrão sem Sobrecarga
    public OrderItem(int quantity, double price, Product product)
    {
        Quantity = quantity;
        Price = price;
        OrderProduct = product;
    }

    public double SubTotal()
    {
        return Price * Quantity;
    }
    public override string ToString()
    {
        return "Order Items: \n"  +
        OrderProduct.NameProduct + "," + "Quantity: " + Quantity + ",Subtotal: " + "$" + SubTotal();
    }
}
