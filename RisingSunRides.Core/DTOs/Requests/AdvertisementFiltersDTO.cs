namespace RisingSunRides.Core.DTOs.Requests
{
    public class AdvertisementFiltersDTO
    {
        public decimal MinPrice { get; set; } = default;
        public decimal MaxPrice { get; set; } = default;
        public string City { get; set; } = string.Empty;
        public int MinYear { get; set; } = default;
        public int MaxYear { get; set; } = default;
        public int ModelId { get; set; } = default;
        public int MakeId { get; set; } = default;
        public int BodyId { get; set; } = default;
        public int TransmissionId { get; set; } = default;
        public int FuelId { get; set; } = default;
        public int DrivetrainId { get; set; } = default;
        public int ConditionId { get; set; } = default;
    }
}
