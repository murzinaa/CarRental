namespace CarRentalService.DataAccess.Entities
{
    public class Car
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int NumberOfSeats { get; set; }

        public string TypeOfEngine { get; set; }

        public double PricePerDay { get; set; }
    }
}
