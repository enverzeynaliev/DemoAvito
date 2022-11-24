using System.Data.Entity;
using DemoAvito.AppServices.Advert.Repositories;
using DemoAvito.Contracts;
using DemoAvito.Domain;
using DemoAvito.Infrastructure;

namespace DemoAvito.DataAccess.EntityConfiguration.DemoAvito;

public class AdvertRepository : IAdvertRepository
{
    private readonly IRepository<Adverts> _repository;

    public AdvertRepository(IRepository<Adverts> repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<DemoAvitoAllDto>> GetAll(int take, int skip,
        CancellationToken cancellationToken)
    {
        return await _repository.GetAll()
            .Select(p => new DemoAvitoAllDto
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                ProductPrice = p.ProductPrice,
                Category = p.Category,
                Location = p.LocationCity,
                CreationDate = p.CreationDate
            })
            .Take(take).Skip(skip).ToListAsync(cancellationToken);
    }

    public async Task<IReadOnlyCollection<DemoAvitoAllDto>> GetAllFiltered(AdvertFilterRequest request,
        CancellationToken cancellationToken)
    {
        var query = _repository.GetAll();
        if (request.ProductID.HasValue)
        {
            query = query.Where(p => p.ProductId == request.ProductID);
        }

        if (!string.IsNullOrWhiteSpace(request.Name))
        {
            query = query.Where(p => p.ProductName.ToLower().Contains(request.Name));
        }

        return await query.Select(p => new DemoAvitoAllDto
        {
            ProductId = p.ProductId,
            ProductName = p.ProductName,
            ProductPrice = p.ProductPrice,
            Category = p.Category,
            Location = p.LocationCity,
            CreationDate = p.CreationDate
        }).ToListAsync(cancellationToken);
    }
}