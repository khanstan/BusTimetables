namespace BusTimetables.Data.Models
{
    using System.Collections.Generic;

    using BusTimetables.Data.Common.Models;

    public partial class Passenger : BaseDeletableModel<int>
    {

        public Passenger()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string EmailAddress { get; set; }

        public int Age { get; set; }

        public Gender Sex { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
