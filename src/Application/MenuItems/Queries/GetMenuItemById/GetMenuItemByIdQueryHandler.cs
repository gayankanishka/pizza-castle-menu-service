using AutoMapper;
using MediatR;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItems.Queries.GetMenuItemById;

public class GetMenuItemByIdQueryHandler : IRequestHandler<GetMenuItemByIdQuery, MenuItemDto?>
{
    private readonly IMapper _mapper;
    private readonly IMenuItemRepository _repository;

    public GetMenuItemByIdQueryHandler(IMapper mapper, IMenuItemRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
    
    public async Task<MenuItemDto?> Handle(GetMenuItemByIdQuery request, CancellationToken cancellationToken)
    {
        var menuItem = await _repository.GetMenuItemAsync(request.Id, cancellationToken);
        return _mapper.Map<MenuItemDto>(menuItem);
    }
}