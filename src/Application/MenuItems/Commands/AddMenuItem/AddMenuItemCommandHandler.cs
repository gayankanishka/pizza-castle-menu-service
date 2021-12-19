using AutoMapper;
using MediatR;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Dtos;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.MenuItems.Commands.AddMenuItem;

public class AddMenuItemCommandHandler : IRequestHandler<AddMenuItemCommand, MenuItemDto>
{
    private readonly IMapper _mapper;
    private readonly IMenuItemRepository _repository;

    public AddMenuItemCommandHandler(IMapper mapper, IMenuItemRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
    
    public async Task<MenuItemDto> Handle(AddMenuItemCommand request, CancellationToken cancellationToken)
    {
        var menuItem = _mapper.Map<MenuItem>(request.AddMenuItemDto);
        menuItem.MenuCategoryId = request.CategoryId;
        await _repository.AddAsync(menuItem, cancellationToken);
        
        return _mapper.Map<MenuItemDto>(menuItem);;
    }
}