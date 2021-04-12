namespace BusTimetables.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BusTimetables.Data.Models;

    public class RoutesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Routes.Any())
            {
                return;
            }

            dbContext.Routes.Add(new Route
            {
                Name = "София - Враца",
                From = "София",
                To = "Враца",
            });
        }
    }
}
