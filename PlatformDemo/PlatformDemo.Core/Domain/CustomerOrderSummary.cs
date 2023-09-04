namespace PlatformDemo.Core.Domain
{
    /// <summary>
    /// Record class to handle object returned by data repository
    /// </summary>
    /// <param name="Id">Unique Identifier</param>
    /// <param name="Name">Name of Customer</param>
    /// <param name="PhoneNumber">PhoneNumber of Customer</param>
    /// <param name="TotalOrderAmount">Total amout of all orders by Customer</param>
    public record class CustomerOrderSummary(int Id, string Name, string PhoneNumber, decimal TotalOrderAmount);
}
