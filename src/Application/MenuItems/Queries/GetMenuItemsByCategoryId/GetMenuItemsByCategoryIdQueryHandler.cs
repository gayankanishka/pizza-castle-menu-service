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
        return await _repository.GetMenuItemsByCategoryId(request.CategoryId)
            .Select(x => _mapper.Map<MenuItemDto>(x))
            .ToListAsync(cancellationToken);
    }
}