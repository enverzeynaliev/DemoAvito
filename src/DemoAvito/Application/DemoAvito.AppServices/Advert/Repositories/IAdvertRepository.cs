using DemoAvito.Contracts;

namespace DemoAvito.AppServices.Advert.Repositories;

public interface IAdvertRepository
{
    /// <summary>
    /// Берем все объявления с пендингом(все по запросу/ под пагинацию)
    /// </summary>
    /// <param name="take"></param>
    /// <param name="skip"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IReadOnlyCollection<DemoAvitoAllDto>> GetAll(int take, int skip, CancellationToken cancellationToken);

    /// <summary>
    /// Берем все по фильтру пользователя
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="take"></param>
    /// <param name="skip"></param>
    /// <returns></returns>
    Task<IReadOnlyCollection<DemoAvitoAllDto>> GetAllFiltered(AdvertFilterRequest request,
        CancellationToken cancellationToken);
}