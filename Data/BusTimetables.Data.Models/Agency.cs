namespace BusTimetables.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using BusTimetables.Data.Common.Models;

    public class Agency : BaseDeletableModel<int>
    {
        public Agency()
        {
            this.Routes = new HashSet<Route>();
            this.Busses = new HashSet<Bus>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<Route> Routes { get; set; }

        public virtual ICollection<Bus> Busses { get; set; }
    }
}
