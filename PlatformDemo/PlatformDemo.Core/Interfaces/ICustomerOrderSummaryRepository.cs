using PlatformDemo.Core.Domain;

namespace PlatformDemo.Core.Interfaces
{
    public interface ICustomerOrderSummaryRepository
    {
        Task<List<CustomerOrderSummary>> GetAsync();
    }
}
