using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItemsByTypeId;

public class GetMenuItemsByTypeIdQueryHandler : IRequestHandler<GetMenuItemsByTypeIdQuery, IEnumerable<MenuItemDto>>
{
    private readonly IMapper _mapper;
    private readonly IMenuItemRepository _repository;

    public GetMenuItemsByTypeIdQueryHandler(IMapper mapper, IMenuItemRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
    
    public async Task<IEnumerable<MenuItemDto>> Handle(GetMenuItemsByTypeIdQuery request,
        CancellationToken cancellationToken)
    {
        var menuItems = await _repository.GetMenuItemsByTypeId(request.TypeId)
            .ToListAsync(cancellationToken);
        
        return _mapper.Map<IEnumerable<MenuItemDto>>(menuItems);
    }
}