using Microsoft.EntityFrameworkCore;
using PlatformDemo.Core.Domain;
using PlatformDemo.Core.Interfaces;
using PlatformDemo.Core.Models;

namespace PlatformDemo.Core.Data.Repositories
{
    /// <summary>
    /// Data repository class for CustomerOrderSummary
    /// </summary>
    public class CustomerOrderSummaryRepository : Repository, ICustomerOrderSummaryRepository
    {
        public CustomerOrderSummaryRepository(LocalDbContext dbContext): base(dbContext) { 
        } 

        /// <summary>
        /// Get list of customers along with total amount of orders
        /// </summary>
        /// <returns>Returns list of CustomerOrderSummary domain objects</returns>
        public Task<List<CustomerOrderSummary>> GetAsync()
        {
            return Task.FromResult(this.Context.Customers
                        .Include("Orders")
                        .Select(s => new CustomerOrderSummary(s.Id, s.Name, s.PhoneNumber ?? string.Empty, s.Orders.Sum(o => o.Amount)))
                        .ToList());
        }
    }
}
