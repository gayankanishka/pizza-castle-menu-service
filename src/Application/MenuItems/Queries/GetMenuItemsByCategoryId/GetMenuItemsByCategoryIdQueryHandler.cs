using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItemsByCategoryId;

public class GetMenuItemsByCategoryIdQueryHandler : IRequestHandler<GetMenuItemsByCategoryIdQuery, IEnumerable<MenuItemDto>>
{
    private readonly IMapper _mapper;
    private readonly IMenuItemRepository _repository;

    public GetMenuItemsByCategoryIdQueryHandler(IMapper mapper, IMenuItemRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
    
    public async Task<IEnumerable<MenuItemDto>> Handle(GetMenuItemsByCategoryIdQuery request,
        CancellationToken cancellationToken)
    {
        var menuItems = await _repository.GetMenuItemsByCategoryId(request.CategoryId)
            .ToListAsync(cancellationToken);
        
        return _mapper.Map<IEnumerable<MenuItemDto>>(menuItems);
    }
}