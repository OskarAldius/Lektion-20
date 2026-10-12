using System;
using System.Globalization;
using Avalonia.Controls;

namespace Client.Models;

public class Customer
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string CustomerId { get; set; } = Guid.NewGuid().ToString();
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public string? AddressLine { get; set; }
    public string? City { get; set; }
    public string? PostNumber { get; set; }

    public void Edit()
    {
        System.Console.WriteLine("Ändra uppgifter");
    }

    public void Delete()
    {
        System.Console.WriteLine("Ta bort kund");

    }
}
