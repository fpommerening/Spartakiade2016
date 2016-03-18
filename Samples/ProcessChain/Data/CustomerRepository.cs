using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FP.Spartakiade2016.ProcessChain.Data.Objects;
using Microsoft.Data.Entity;

namespace FP.Spartakiade2016.ProcessChain.Data
{
    public class CustomerRepository
    {
        public Task<bool> CustomerExists(BOCustomer customer)
        {
            using (var content = new CustomerContext())
            {
                return content.Customers.AnyAsync(x =>
                    x.Name == customer.Name &&
                    x.FirstName == customer.FirstName &&
                    x.DeliveryAddress.City == customer.DeliveryAddress.City &&
                    x.DeliveryAddress.ZipCode == customer.DeliveryAddress.ZipCode &&
                    x.DeliveryAddress.Street == customer.DeliveryAddress.Street &&
                    x.DeliveryAddress.Number == customer.DeliveryAddress.Number
                    );
            }
        }

        public async Task<Guid> GetCustomerId(string customerNumber)
        {
            using (var content = CreateCustomerContext())
            {
                var existingCustomer = await content.Customers.FirstOrDefaultAsync(x => x.Number == customerNumber);
                return existingCustomer?.Id ?? Guid.Empty;
            }
        }

        public Task CreateCustomer(BOCustomer customer)
        {
            using (var content = CreateCustomerContext())
            {
                return content.SaveChangesAsync();
            }
        }

        private CustomerContext CreateCustomerContext()
        {
            return new CustomerContext();
        }

    }
}
