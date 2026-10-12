using System;
using Avalonia.Rendering.Composition;

namespace Client.Models;

public class Order
{
    public string OrderNumber { get; set; } = Guid.NewGuid().ToString();
    public required string ProductName { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public string? Status { get; set; }

    public bool IsPaid { get; set; }
    public void Edit()
    {
        System.Console.WriteLine("Ändra uppgifter");
    }

    public void Delete()
    {
        System.Console.WriteLine("Ta bort vara");

    }

}
