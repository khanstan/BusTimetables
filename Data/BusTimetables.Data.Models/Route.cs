namespace BusTimetables.Data.Models
{
    using System.Collections.Generic;

    using BusTimetables.Data.Common.Models;

    public partial class Route : BaseDeletableModel<int>
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string From { get; set; }

        public string To { get; set; }

    }
}
