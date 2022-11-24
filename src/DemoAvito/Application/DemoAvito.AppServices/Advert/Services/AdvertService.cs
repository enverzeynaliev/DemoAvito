using DemoAvito.AppServices.Advert.Repositories;
using DemoAvito.Contracts;

namespace DemoAvito.AppServices.Advert.Services;

/// <inheritdoc />
public class AdvertService : IAdvertService
{
    public readonly IAdvertRepository _AdvertRepository;

    public AdvertService(IAdvertRepository advertRepository)
    {
        _AdvertRepository = advertRepository;
    }

    /// <inheritdoc />
    public Task<IReadOnlyCollection<DemoAvitoAllDto>> GetAll(int take, int skip, CancellationToken cancellationToken)
    {
        return _AdvertRepository.GetAll(take, skip, cancellationToken);
    }

    /// <inheritdoc />
    public Task<IReadOnlyCollection<DemoAvitoAllDto>> GetAllFiltered(AdvertFilterRequest request,
        CancellationToken cancellationToken)
    {
        return _AdvertRepository.GetAllFiltered(request, cancellationToken);
    }
}