using System.Collections.Generic;
using AssemblyConsole.Entities;

namespace AssemblyConsole.src;

public abstract class TestProducts
{
    public static void Master()
    {
        System.Console.Write("Enter the number of products: ");
        var n = int.Parse(Console.ReadLine());
        List<Product> products = new List<Product>();

        for(int i = 0; i < n; i++)
        {   
            System.Console.WriteLine();
            System.Console.WriteLine("Product #" + n + " data: ");
            System.Console.Write("Common, used or imported (c/u/i)? ");
            var typeProduct = char.Parse(Console.ReadLine());
            
            System.Console.Write("Name: ");
            var name = Console.ReadLine();
            System.Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            if(typeProduct == 'i')
            {
                System.Console.Write("Customs Fee: ");
                double customsfee = double.Parse(Console.ReadLine());
                products.Add(new ImportedProduct(name,price, customsfee));

            }else if (typeProduct == 'c')
            {
                products.Add(new(name, price));
            }else 
            {
                System.Console.Write("Manufacture Date (DD/MM/YYYY):  ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                products.Add(new UsedProduct(name, price, manufactureDate));
            }
        }
        System.Console.WriteLine("PRICE TAGS: ");
        
        foreach(Product product in products)
        {
            product.PriceTag();   
        }
    }
}
