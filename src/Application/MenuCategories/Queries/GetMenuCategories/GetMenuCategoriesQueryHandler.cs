using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuCategories.Queries.GetMenuCategories;

public class GetMenuCategoriesQueryHandler : IRequestHandler<GetMenuCategoriesQuery, IEnumerable<MenuCategoryDto>>
{
    private readonly IMapper _mapper;
    private readonly IMenuCategoryRepository _repository;
    
    public GetMenuCategoriesQueryHandler(IMapper mapper, IMenuCategoryRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
    
    public async Task<IEnumerable<MenuCategoryDto>> Handle(GetMenuCategoriesQuery request, CancellationToken cancellationToken)
    {
        var menuCategories = await _repository.GetAll()
            .ToListAsync(cancellationToken);

        return _mapper.Map<IEnumerable<MenuCategoryDto>>(menuCategories);
    }
}