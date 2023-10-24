namespace RisingSunRides.Core.DTOs.Responses
{
    public class AdvertisementDTO
    {
        public string AdvertisementName { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; } = null!;

        public string OwnerName { get; set; } = null!;
        public string OwnerPhone { get; set; } = null!;

        public string VIN { get; set; } = null!;
        public int Year { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int BodyId { get; set; }
        public int TransmissionId { get; set; }
        public int FuelId { get; set; }
        public int DrivetrainId { get; set; }
        public int ConditionId { get; set; }
    }
}
