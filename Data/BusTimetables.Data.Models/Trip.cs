namespace BusTimetables.Data.Models
{
    using System;

    using BusTimetables.Data.Common.Models;

    public class Trip : BaseDeletableModel<int>
    {
        public int Id { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public TimeSpan Duration { get; set; }

        public int ReservedSeats { get; set; }

        public string Status { get; set; }

        public int AgencyId { get; set; }

        public virtual Agency Agency { get; set; }

        public int BusId { get; set; }

        public virtual Bus Bus { get; set; }

        public int RouteId { get; set; }

        public virtual Route Route { get; set; }
    }
}
