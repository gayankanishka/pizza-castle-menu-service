using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItems;

public class GetMenuItemsQueryHandler : IRequestHandler<GetMenuItemsQuery, IEnumerable<MenuItemDto>>
{
    private readonly IMapper _mapper;
    private readonly IMenuItemRepository _repository;
    
    public GetMenuItemsQueryHandler(IMapper mapper, IMenuItemRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<IEnumerable<MenuItemDto>> Handle(GetMenuItemsQuery request, CancellationToken cancellationToken)
    {
         return await _repository.GetAll()
             .OrderBy(x => x.Name)
             .Select(x => _mapper.Map<MenuItemDto>(x))
             .ToListAsync(cancellationToken);
    }
}