using System;
using System.Threading.Tasks;
using FP.Spartakiade2016.ProcessChain.Data.Models;
using FP.Spartakiade2016.ProcessChain.Data.Objects;
using Microsoft.Data.Entity;

namespace FP.Spartakiade2016.ProcessChain.Data
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
        }


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

        public async Task<Guid> GetBillId(Guid customerId, string billNumber)
        {
            using (var content = CreateCustomerContext())
            {
                var existingBill = await content.Bills.FirstOrDefaultAsync(x => x.Number == billNumber && x.Customerid == customerId);
                return existingBill?.Id ?? Guid.Empty;
            }
        }

        public Task CreateBill(BOBill boBill)
        {
            using (var content = CreateCustomerContext())
            {
                return content.SaveChangesAsync();
            }
        }

        public Task CreateReversal(BOReversal boReversal)
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
