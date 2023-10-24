namespace RisingSunRides.Application.Extensions
{
    public static class AdvertisementExtensions
    {
        public static IQueryable<Advertisement> FilterByMinPrice(this IQueryable<Advertisement> advertisements, decimal minPrice)
        {
            return advertisements.Where(a => a.Price >= minPrice);
        }

        public static IQueryable<Advertisement> FilterByMaxPrice(this IQueryable<Advertisement> advertisements, decimal maxPrice)
        {
            return advertisements.Where(a => a.Price <= maxPrice);
        }

        public static IQueryable<Advertisement> FilterByCity(this IQueryable<Advertisement> advertisements, string city)
        {
            return advertisements.Where(a => a.City == city);
        }

        public static IQueryable<Advertisement> FilterByMinYear(this IQueryable<Advertisement> advertisements, int minYear)
        {
            return advertisements.Where(a => a.Car.Year >= minYear);
        }

        public static IQueryable<Advertisement> FilterByMaxYear(this IQueryable<Advertisement> advertisements, int maxYear)
        {
            return advertisements.Where(a => a.Car.Year <= maxYear);
        }

        public static IQueryable<Advertisement> FilterByModel(this IQueryable<Advertisement> advertisements, int modelId)
        {
            return advertisements.Where(a => a.Car.ModelId == modelId);
        }

        public static IQueryable<Advertisement> FilterByMake(this IQueryable<Advertisement> advertisements, int makeId)
        {
            return advertisements.Where(a => a.Car.Model.MakeId == makeId);
        }

        public static IQueryable<Advertisement> FilterByBody(this IQueryable<Advertisement> advertisements, int bodyId)
        {
            return advertisements.Where(a => a.Car.BodyId == bodyId);
        }

        public static IQueryable<Advertisement> FilterByTransmission(this IQueryable<Advertisement> advertisements, int transmissionId)
        {
            return advertisements.Where(a => a.Car.TransmissionId == transmissionId);
        }

        public static IQueryable<Advertisement> FilterByFuel(this IQueryable<Advertisement> advertisements, int fuelId)
        {
            return advertisements.Where(a => a.Car.FuelId == fuelId);
        }

        public static IQueryable<Advertisement> FilterByDrivetrain(this IQueryable<Advertisement> advertisements, int drivetrainId)
        {
            return advertisements.Where(a => a.Car.DrivetrainId == drivetrainId);
        }

        public static IQueryable<Advertisement> FilterByCondition(this IQueryable<Advertisement> advertisements, int conditionId)
        {
            return advertisements.Where(a => a.Car.ConditionId == conditionId);
        }
    }
}
