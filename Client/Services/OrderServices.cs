using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class OrderServices : IOrderService
{


    public List<Order> List()
    {
        Storage<Order> storage = new();
        var _path = Environment.CurrentDirectory + "/Data/orders.json";
        var json = storage.Read(_path);
        return json;
    }


}

