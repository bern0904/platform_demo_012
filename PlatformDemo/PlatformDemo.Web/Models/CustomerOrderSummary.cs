using System.ComponentModel.DataAnnotations;

namespace PlatformDemo.Web.Models
{
    /// <summary>
    /// Web model which corresponds to the data model for CustomerOrderSummary.
    /// </summary>
    public class CustomerOrderSummary
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Total Amount ($)")]
        public decimal TotalOrderAmount { get; set; }
    }
}
