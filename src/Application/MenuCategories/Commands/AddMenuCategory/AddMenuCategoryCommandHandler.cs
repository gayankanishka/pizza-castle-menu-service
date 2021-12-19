using AutoMapper;
using MediatR;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Dtos;
using PizzaCastle.MenuService.Domain.Entities;

namespace PizzaCastle.MenuService.Application.MenuCategories.Commands.AddMenuCategory;

public class AddMenuCategoryCommandHandler : IRequestHandler<AddMenuCategoryCommand, MenuCategoryDto>
{
    private readonly IMapper _mapper;
    private readonly IMenuCategoryRepository _repository;

    public AddMenuCategoryCommandHandler(IMapper mapper, IMenuCategoryRepository repository)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<MenuCategoryDto> Handle(AddMenuCategoryCommand request, CancellationToken cancellationToken)
    {
        var result = await _repository.AddAsync(
            _mapper.Map<MenuCategory>(request.AddMenuCategoryDto));
        return _mapper.Map<MenuCategoryDto>(result);
    }
}