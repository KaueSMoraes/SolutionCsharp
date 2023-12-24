namespace AssemblyConsole.Entities;

public class Product
{
    public string NameProduct { get; private set; }
    public double PriceProduct { get; private set; }

    public Product(string name, double price)
    {
        NameProduct = name;
        PriceProduct = price;
    }
}
