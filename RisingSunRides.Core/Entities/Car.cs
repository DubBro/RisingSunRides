namespace RisingSunRides.Core.Entities
{
    public class Car : AbstractEntity
    {
        public string VIN { get; set; } = null!;
        public int Year { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; } = null!;

        public int BodyId { get; set; }
        public Body Body { get; set; } = null!;

        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set; } = null!;

        public int FuelId { get; set; }
        public Fuel Fuel { get; set; } = null!;

        public int DrivetrainId { get; set; }
        public Drivetrain Drivetrain { get; set; } = null!;

        public int ConditionId { get; set; }
        public Condition Condition { get; set; } = null!;

        public Advertisement Advertisement { get; set; } = null!;
    }
}