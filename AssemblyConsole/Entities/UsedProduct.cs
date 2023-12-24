using System.Globalization;

namespace AssemblyConsole.Entities;
class UsedProduct : Product
{   
    public DateTime ManufactureDate  {get; set;}
    public UsedProduct(string name, double price, DateTime manufacture) : base (name, price)
    {
        ManufactureDate = manufacture;  
    }

    public override string PriceTag()
    {
        return NameProduct + "$" + "(used)  $" +    
        PriceProduct.ToString("F2", CultureInfo.InvariantCulture) + 
        " (Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
    }
}
