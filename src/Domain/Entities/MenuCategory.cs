using System.ComponentModel.DataAnnotations;
using PizzaCastle.MenuService.Domain.Common;

namespace PizzaCastle.MenuService.Domain.Entities;

public class MenuCategory : AuditableEntity
{
    public Guid Id { get; set; }
    [Required]
    public string? Name { get; set; }
}