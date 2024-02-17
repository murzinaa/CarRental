﻿namespace CarRentalService.DataAccess.Entities
{
    public class Reservation
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int CarId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ExpectedReturnDate { get; set; }

        public DateTime? ActualReturnDate { get; set; }

        public double TotalSum { get; set; }

        public virtual Car Car { get; set; }

        public virtual Client Client { get; set; }
    }
}
