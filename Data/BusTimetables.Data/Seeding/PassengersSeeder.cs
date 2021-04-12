using BusTimetables.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BusTimetables.Data.Seeding
{
    public class PassengersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Passengers.Any())
            {
                return;
            }

            dbContext.Passengers.Add(new Passenger
            {
                FirstName = "Илия",
                LastName = "Луков",
                PhoneNumber = "0885345665",
                Address = "гр. София",
                EmailAddress = "iliq_lukov@abv.bg",
                Age = 54,
                Sex = Passenger.Gender.Male,
            });
            dbContext.Passengers.Add(new Passenger
            {
                FirstName = "Калинка",
                LastName = "Тричкова",
                PhoneNumber = "0885745222",
                Address = "с. Замфирово",
                EmailAddress = "trikitrikitrikvamte@yahoo.com",
                Age = 18,
                Sex = Passenger.Gender.Female,
            });
            dbContext.Passengers.Add(new Passenger
            {
                FirstName = "Кольо",
                LastName = "Фичката",
                PhoneNumber = "0876542789",
                Address = "гр. Ловеч",
                EmailAddress = "fi4444kata@abv.bg",
                Age = 65,
                Sex = Passenger.Gender.Male,
            });
            dbContext.Passengers.Add(new Passenger
            {
                FirstName = "Ани",
                LastName = "Димова",
                PhoneNumber = "0887744565",
                Address = "гр. Враца",
                EmailAddress = "ani4kabani4ka@abv.bg",
                Age = 26,
                Sex = Passenger.Gender.Female,
            });
        }
    }
}