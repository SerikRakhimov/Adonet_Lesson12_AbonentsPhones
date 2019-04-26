using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonentsPhones
{
    public class DataInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Cities.AddRange(new List<City>{
                new City
                {
                    Name = "Нур-Султан",
                    Kod = "8-717-2"
                },
                new City
                {
                    Name = "Алматы",
                    Kod = "8-727-2"
                },
                new City
                {
                    Name = "Стамбул",
                    Kod = "3-333-1"
                }
            });
            context.SaveChanges();
        }
    }
}
