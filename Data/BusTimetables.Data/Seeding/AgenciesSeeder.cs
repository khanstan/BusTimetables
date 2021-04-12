namespace BusTimetables.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BusTimetables.Data.Models;

    public class AgenciesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Agencies.Any())
            {
                return;
            }

            dbContext.Agencies.Add(new Agency { Name = "Юнион Ивкони" });
            dbContext.Agencies.Add(new Agency { Name = "Кента АД" });
            dbContext.Agencies.Add(new Agency { Name = "Олмена ООД" });
            dbContext.Agencies.Add(new Agency { Name = "Виктори 13 ООД" });
            dbContext.Agencies.Add(new Agency { Name = "Нешев ООД" });
        }
    }
}