using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetAllMenuItems;

public class GetAllMenuItemsQueryHandler : IRequestHandler<GetAllMenuItemsQuery, IEnumerable<MenuItemDto>>
{
    private readonly IMapper _mapper;
    private readonly IMenuItemRepository _menuItemRepository;
    
    public GetAllMenuItemsQueryHandler(IMapper mapper, IMenuItemRepository menuItemRepository)
    {
        _mapper = mapper;
        _menuItemRepository = menuItemRepository;
    }

    public async Task<IEnumerable<MenuItemDto>> Handle(GetAllMenuItemsQuery request, CancellationToken cancellationToken)
    {
        var menuItems = await _menuItemRepository.GetMenuItems()
            .ToListAsync(cancellationToken);

        return _mapper.Map<IEnumerable<MenuItemDto>>(menuItems);
    }
}