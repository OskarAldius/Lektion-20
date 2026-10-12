using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Avalonia.Controls.Platform;
using Client.Models;
using Client.Repositories;
using Microsoft.VisualBasic;

namespace Client.Services;

public class ProductServices
{



    static Storage<Product> storage = new();
    public static List<Product> ListAllProducts()
    {
        var _path = Directory.GetCurrentDirectory() + "/Data/products.json";
        var json = storage.Read(_path);
        var sortJson = json.OrderBy(x => x.ItemNumber).ToList();
        return sortJson;
    }
}
