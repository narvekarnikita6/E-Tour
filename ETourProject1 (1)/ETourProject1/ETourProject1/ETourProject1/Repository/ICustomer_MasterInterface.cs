using ETourProject1.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ETourProject1.Repository
{
    public interface ICustomer_MasterInterface
    {
        Task<ActionResult<Customer_Master>> AddCustomer(Customer_Master customer);

        Task<Customer_Master> GetById(int id);

        Task<ActionResult<IEnumerable<Customer_Master>?>> GetCustomers();






    }
}
