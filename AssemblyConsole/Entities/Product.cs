using System.Globalization;

namespace AssemblyConsole.Entities;

public class Product
{
    public string NameProduct { get; protected set; }
    public double PriceProduct { get; protected set; }

    public Product(string name, double price)
    {
        NameProduct = name;
        PriceProduct = price;
    }

    //Retorno de Etiqueta
    public virtual string PriceTag()
    {
        return NameProduct + "$" + 
        PriceProduct.ToString("F2", CultureInfo.InvariantCulture);
    }
}
