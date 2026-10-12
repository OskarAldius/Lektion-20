using System;
using System.Collections.Generic;
using System.IO;
using Client.Interfaces;
using Client.Models;
using Client.Repositories;

namespace Client.Services;


public class CustomerServices : ICustomerService
{


    public List<Customer> List()
    {
        Storage<Customer> storage = new();
        var _path = Environment.CurrentDirectory + "/Data/customers.json";
        var json = storage.Read(_path);
        return json;
    }


}
