namespace BusTimetables.Data.Models
{
    using System.Collections.Generic;

    using BusTimetables.Data.Common.Models;

    public class Bus : BaseDeletableModel<int>
    {
        public Bus()
        {
            this.Tickets = new HashSet<Ticket>();
            this.Passengers = new HashSet<Passenger>();
        }

        public int Id { get; set; }

        public string PlateNumber { get; set; }

        public int AgencyId { get; set; }

        public Agency Agency { get; set; }

        public string Driver { get; set; }

        public bool WiFi { get; set; }

        public string Status { get; set; }

        public int Seats { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public ICollection<Passenger> Passengers { get; set; }
    }
}
