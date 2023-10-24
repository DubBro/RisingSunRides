namespace RisingSunRides.Application.Services.Interfaces
{
    public interface IAdvertisementService
    {
        Task<IList<AdvertisementDTO>> GetAdvertisementsAsync(AdvertisementFiltersDTO filters);
    }
}
