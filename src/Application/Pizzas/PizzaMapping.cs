using AutoMapper;
using PizzaCastle.MenuService.Domain.Dtos;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.Pizzas;

public class PizzaMapping : Profile
{
    public PizzaMapping()
    {
        CreateMap<Pizza, PizzaDto>();
    }
}