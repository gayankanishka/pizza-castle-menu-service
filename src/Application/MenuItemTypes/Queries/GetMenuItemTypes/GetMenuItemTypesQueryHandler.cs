using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PizzaCastle.MenuService.Application.Common;
using PizzaCastle.MenuService.Domain.Dtos;

namespace PizzaCastle.MenuService.Application.MenuItemTypes.Queries.GetMenuItemTypes;

public class GetMenuItemTypesQueryHandler : IRequestHandler<GetMenuItemTypesQuery, IEnumerable<MenuItemTypeDto>>
{
    private readonly IMapper _mapper;
    private readonly IMenuItemTypeRepository _repository;
    
    public GetMenuItemTypesQueryHandler(IMapper mapper, IMenuItemTypeRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
    
    public async Task<IEnumerable<MenuItemTypeDto>> Handle(GetMenuItemTypesQuery request, CancellationToken cancellationToken)
    {
        var menuItemTypes = await _repository.GetAll()
            .ToListAsync(cancellationToken);

        return _mapper.Map<IEnumerable<MenuItemTypeDto>>(menuItemTypes);
    }
}