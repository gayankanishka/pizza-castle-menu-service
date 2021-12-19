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
    private readonly IMenuCategoryRepository _categoryRepository;

    public AddMenuItemCommandHandler(IMapper mapper, IMenuItemRepository repository, IMenuCategoryRepository categoryRepository)
    {
        _mapper = mapper;
        _repository = repository;
        _categoryRepository = categoryRepository;
    }
    
    public async Task<MenuItemDto> Handle(AddMenuItemCommand request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetMenuCategoryAsync(request.CategoryId, cancellationToken);

        if (category == null)
        {
            throw new Exception("Category not found");
        }
        
        var menuItem = _mapper.Map<MenuItem>(request.AddMenuItemDto);
        menuItem.MenuCategory = category;
        
        await _repository.AddAsync(menuItem, cancellationToken);
        
        return _mapper.Map<MenuItemDto>(menuItem);;
    }
}