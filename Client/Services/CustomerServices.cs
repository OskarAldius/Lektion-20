using System;
using System.Collections.Generic;
using System.IO;
using Client.Models;
using Client.Repositories;

namespace Client.Services;

public class CustomerServices
{


    static Storage<Customer> storage = new();
    public static List<Customer> ListAllCustomers()
    {
        var _path = Environment.CurrentDirectory + "/Data/customers.json";
        var json = storage.Read(_path);
        return json;
    }


}
