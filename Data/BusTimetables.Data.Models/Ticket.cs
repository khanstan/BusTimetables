namespace BusTimetables.Data.Models
{
    using System;

    using BusTimetables.Data.Common.Models;

    public class Ticket : BaseDeletableModel<int>
    {
        public int Id { get; set; }

        public string RouteFrom { get; set; }

        public string RouteTo { get; set; }

        public int Seat { get; set; }

        public DateTime Date { get; set; }

        public int PassengerId { get; set; }

        public Passenger Passenger { get; set; }

        public int BusId { get; set; }

        public Bus Bus { get; set; }

    }
}
