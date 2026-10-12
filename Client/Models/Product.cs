using System;

namespace Client.Models;

public class Product
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public required string ItemNumber { get; set; }
    public required string Name { get; set; }
    public required string SupplierName { get; set; }
    public int Price { get; set; }


    public void Edit()
    {
        System.Console.WriteLine("Ändra uppgifter");
    }

    public void Delete()
    {
        System.Console.WriteLine("Ta bort produkt");

    }
}
