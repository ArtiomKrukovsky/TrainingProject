using Remember3._0.Domain.Models;
using Remember3._0.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remember3._0.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        GeneralRepository<Product> Products { get; }
        GeneralRepository<Customer> Customers { get; }
        void SaveChanges();
    }
}
