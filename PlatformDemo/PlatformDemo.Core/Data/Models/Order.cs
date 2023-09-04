using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlatformDemo.Core.Models;

/// <summary>
/// Order EF Entity Model
/// </summary>
[Table("Order")]
public partial class Order
{
    [Key]
    public int Id { get; set; }

    public int CustomerId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string OrderNumber { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Orders")]
    public virtual Customer Customer { get; set; } = null!;
}
