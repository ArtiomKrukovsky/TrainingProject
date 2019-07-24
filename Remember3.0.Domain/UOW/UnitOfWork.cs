using Remember3._0.Domain.Interfaces;
using Remember3._0.Domain.Models;
using Remember3._0.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remember3._0.Domain.UOW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        ProductContext context = new ProductContext();

        private GeneralRepository<Product> productRepository { get; set; }
        private GeneralRepository<Customer> customerRepository { get; set; }

        public GeneralRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new GeneralRepository<Product>(context);
                return productRepository;
            }
        }

        public GeneralRepository<Customer> Customers
        {
            get
            {
                if (customerRepository == null)
                    customerRepository = new GeneralRepository<Customer>(context);
                return customerRepository;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
