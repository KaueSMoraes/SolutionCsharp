using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace AssemblyConsole.Entities;

public class ImportedProduct : Product
{
    public double CustomsFee { get; set; }
    public ImportedProduct(string name, double price, double customs) : base(name, price)
    {
        CustomsFee = customs;
    }   

    public override string PriceTag()
    {
        return NameProduct + "$" + 
        PriceProduct.ToString("F2", CultureInfo.InvariantCulture) +
        "(Customs Fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
    }

    public double TotalPrice()
    {
        return PriceProduct += CustomsFee;
    }
}
