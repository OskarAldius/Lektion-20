using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Avalonia.Controls.Platform;
using Client.Interfaces;
using Client.Models;
using Client.Repositories;
using Microsoft.VisualBasic;

namespace Client.Services;

public class ProductServices : IProductService
{



    public List<Product> List()
    {
        Storage<Product> storage = new();
        var _path = Directory.GetCurrentDirectory() + "/Data/products.json";
        var json = storage.Read(_path);
        var sortJson = json.OrderBy(x => x.ItemNumber).ToList();
        return sortJson;
    }
}
