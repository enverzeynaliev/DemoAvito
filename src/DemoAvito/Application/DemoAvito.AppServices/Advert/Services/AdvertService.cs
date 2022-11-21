using DemoAvito.Contracts;

namespace DemoAvito.AppServices.Advert.Services;

public class AdvertService : IAdvertService
{
    public Task<IReadOnlyCollection<DemoAvitoAllDto>> GetAll(int take, int skip)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<DemoAvitoAllDto>> GetAllFiltered(AdvertFilterRequest request)
    {
        throw new NotImplementedException();
    }
}