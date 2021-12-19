using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetAllMenuItems;

public class GetAllMenuItemsQueryHandler : IRequestHandler<GetAllMenuItemsQuery, IEnumerable<MenuItemDto>>
{
    private readonly IMapper _mapper;
    private readonly IMenuItemRepository _repository;
    
    public GetAllMenuItemsQueryHandler(IMapper mapper, IMenuItemRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<IEnumerable<MenuItemDto>> Handle(GetAllMenuItemsQuery request, CancellationToken cancellationToken)
    {
         return await _repository.GetMenuItems()
             .Select(x => _mapper.Map<MenuItemDto>(x))
             .OrderBy(x => x.Name)
             .ToListAsync(cancellationToken);
    }
}