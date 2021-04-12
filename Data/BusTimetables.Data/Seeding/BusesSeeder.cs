namespace BusTimetables.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BusTimetables.Data.Models;

    public class BusesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Buses.Any())
            {
                return;
            }

            dbContext.Buses.Add(new Bus
            {
                PlateNumber = "ОВ4444АР",

                Agency = dbContext.Agencies.Where(a => a.Id == 4).FirstOrDefault(),

                Driver = "Иван Иванов",

                WiFi = true,

                Status = "Stopped",

                Seats = 34,
            });
            dbContext.Buses.Add(new Bus
            {
                PlateNumber = "С1919АТ",

                Agency = dbContext.Agencies.Where(a => a.Id == 1).FirstOrDefault(),

                Driver = "Георг Георгиев",

                WiFi = false,

                Status = "Travelling",

                Seats = 12,
            });

            dbContext.Buses.Add(new Bus
            {
                PlateNumber = "У8888ВС",

                Agency = dbContext.Agencies.Where(a => a.Id == 2).FirstOrDefault(),

                Driver = "Йордан Илиев",

                WiFi = true,

                Status = "Travelling",

                Seats = 50,
            });

            dbContext.Buses.Add(new Bus
            {
                PlateNumber = "ВР1500СС",

                Agency = dbContext.Agencies.Where(a => a.Id == 3).FirstOrDefault(),

                Driver = "Крум Пастърджиев",

                WiFi = false,

                Status = "Travelling",

                Seats = 10,
            });
        }

    }
}