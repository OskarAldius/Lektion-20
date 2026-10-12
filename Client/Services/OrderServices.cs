using System;
using System.Collections.Generic;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class OrderServices
{


    static Storage<Order> storage = new();
    public static List<Order> ListAllProducts()
    {
        var _path = Environment.CurrentDirectory + "/Data/orders.json";
        var json = storage.Read(_path);
        return json;
    }


}
