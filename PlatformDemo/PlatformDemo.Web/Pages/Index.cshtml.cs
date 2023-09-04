using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PlatformDemo.Core.Interfaces;
using PlatformDemo.Web.Models;

namespace CustomerOrders.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICustomerOrderSummaryRepository _repository;
        public IndexModel(ILogger<IndexModel> logger,
                          ICustomerOrderSummaryRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        List<CustomerOrderSummary> _customerOrderSummaries;
        public List<CustomerOrderSummary> customerOrderSummaries {
            get
            {
                return _customerOrderSummaries;
            }
        }

        public async Task<IActionResult> OnGet()
        {
            try
            {
                var result = await _repository.GetAsync();
                _customerOrderSummaries = result.Select(s => new CustomerOrderSummary() { 
                    Id = s.Id,
                    Name = s.Name,
                    PhoneNumber = s.PhoneNumber,
                    TotalOrderAmount = s.TotalOrderAmount
                }).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return Page();
        }
    }
}