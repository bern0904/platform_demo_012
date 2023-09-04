using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlatformDemo.Core.Models;

namespace PlatformDemo.Core.Data.Services
{
    /// <summary>
    /// Data Seeding service class
    /// </summary>
    public static class DataService
    {
        /// <summary>
        /// Initializes the sample data. Called upon application initialization.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LocalDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LocalDbContext>>()))
            {
                if (context == null || context.Customers == null)
                {
                    throw new ArgumentNullException("Null LocalDbContext");
                }

                if (context.Customers.Any())
                {
                    return;
                }
             
                context.Customers.AddRange(
                    new Customer
                    {
                        Name = "Helena North",
                        PhoneNumber = "(416) 499-4890",
                        Orders = new List<Order>(){
                            new Order
                            {
                                OrderNumber = "OR-001",
                                Amount = 5
                            },
                            new Order
                            {
                                OrderNumber = "OR-002",
                                Amount = 3
                            }
                        }
                    },
                    new Customer
                    {
                        Name = "Nash David",
                        PhoneNumber = "(416) 315-9558"
                    },
                    new Customer
                    {
                        Name = "Kyler Marks",
                        PhoneNumber = "(289) 868-8852",
                        Orders = new List<Order>(){
                            new Order
                            {
                                OrderNumber = "OR-003",
                                Amount = 3
                            }
                        }
                    },
                    new Customer
                    {
                        Name = "Brooke Wilkinson",
                        PhoneNumber = "(905) 503-6463"
                    },
                    new Customer
                    {
                        Name = "Helena North",
                        PhoneNumber = "(416) 531-9642"
                    },
                    new Customer
                    {
                        Name = "Avery Miller",
                        PhoneNumber = "(905) 434-8233",
                        Orders = new List<Order>(){
                            new Order
                            {
                                OrderNumber = "OR-004",
                                Amount = 8.5M
                            }
                        }
                    },
                    new Customer
                    {
                        Name = "Gemma Oak",
                        PhoneNumber = "(613) 230-5593"
                    },
                    new Customer
                    {
                        Name = "Jasmine Sim",
                        PhoneNumber = "(905) 374-0808"
                    },
                    new Customer
                    {
                        Name = "Frank Segal",
                        PhoneNumber = "(905) 826-1118",
                        Orders = new List<Order>(){
                            new Order
                            {
                                OrderNumber = "OR-005",
                                Amount = 5.5M
                            }
                        }
                    },
                    new Customer
                    {
                        Name = "Gavin Gill",
                        PhoneNumber = "(519) 426-3321"
                    },
                    new Customer
                    {
                        Name = "Mark Piers",
                        PhoneNumber = "(905) 773-1988"
                    },
                    new Customer
                    {
                        Name = "Aiden Logan",
                        PhoneNumber = "(519) 743-7792"
                    },
                    new Customer
                    {
                        Name = "Harper Nevin",
                        PhoneNumber = "(905) 712-2058"
                    },
                    new Customer
                    {
                        Name = "Maya Lake",
                        PhoneNumber = "(416) 673-8100"
                    },
                    new Customer
                    {
                        Name = "Sara Beech",
                        PhoneNumber = "(905) 795-8866"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
