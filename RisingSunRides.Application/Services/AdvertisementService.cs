namespace RisingSunRides.Application.Services
{
    public class AdvertisementService : IAdvertisementService
    {
        private readonly IApplicationDbContext _context;

        public AdvertisementService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<AdvertisementDTO>> GetAdvertisementsAsync(AdvertisementFiltersDTO filters)
        {
            var query = _context.Advertisements.AsQueryable();

            if (filters.MinPrice != default)
            {
                query = query.FilterByMinPrice(filters.MinPrice);
            }

            if (filters.MaxPrice != default)
            {
                query = query.FilterByMaxPrice(filters.MaxPrice);
            }

            if (!string.IsNullOrEmpty(filters.City))
            {
                query = query.FilterByCity(filters.City);
            }

            if (filters.MinYear != default)
            {
                query = query.FilterByMinYear(filters.MinYear);
            }

            if (filters.MaxYear != default)
            {
                query = query.FilterByMaxYear(filters.MaxYear);
            }

            if (filters.ModelId != default)
            {
                query = query.FilterByModel(filters.ModelId);
            }
            else if (filters.MakeId != default)
            {
                query = query.FilterByMake(filters.MakeId);
            }

            if (filters.BodyId != default)
            {
                query = query.FilterByBody(filters.BodyId);
            }

            if (filters.TransmissionId != default)
            {
                query = query.FilterByTransmission(filters.TransmissionId);
            }

            if (filters.FuelId != default)
            {
                query = query.FilterByFuel(filters.FuelId);
            }

            if (filters.DrivetrainId != default)
            {
                query = query.FilterByDrivetrain(filters.DrivetrainId);
            }

            if (filters.ConditionId != default)
            {
                query = query.FilterByCondition(filters.ConditionId);
            }

            var data = await query.Include(a => a.Car).ThenInclude(c => c.Model).Include(a => a.Owner).ToListAsync();

            IList<AdvertisementDTO> result = new List<AdvertisementDTO>();

            foreach (var row in data)
            {
                var advertDTO = new AdvertisementDTO()
                {
                    AdvertisementName = row.Name,
                    Description = row.Description,
                    Price = row.Price,
                    City = row.City,
                    OwnerName = row.Owner.Name,
                    OwnerPhone = row.Owner.Phone,
                    VIN = row.Car.VIN,
                    Year = row.Car.Year,
                    MakeId = row.Car.Model.MakeId,
                    ModelId = row.Car.ModelId,
                    BodyId = row.Car.BodyId,
                    TransmissionId = row.Car.TransmissionId,
                    FuelId = row.Car.FuelId,
                    DrivetrainId = row.Car.DrivetrainId,
                    ConditionId = row.Car.ConditionId,
                };

                result.Add(advertDTO);
            }

            return result;
        }
    }
}
