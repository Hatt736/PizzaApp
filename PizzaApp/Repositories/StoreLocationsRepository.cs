using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Repositories
{
    public class StoreLocationsRepository
    {
        public StoreLocationsRepository()
        {

            StoreList = new List<Store>
            {
            new Store { StoreNumber = "1",
                PhoneNumber = "555-5555",
                StreetAddress = "123 Main St",
                City = "Orlando",
                State = "Florida",
                PostalCode = "45676",
                EmailAddress = "store1@hatts.com",
                Latitude = 98,
                Longitude = 78},

             new Store { StoreNumber = "2",
                PhoneNumber = "555-5555",
                StreetAddress = "123 Main St",
                City = "Orlando",
                State = "Florida",
                PostalCode = "45676",
                EmailAddress = "store1@hatts.com",
                Latitude = 77,
                Longitude = 11 },

              new Store { StoreNumber = "3",
                PhoneNumber = "555-5555",
                StreetAddress = "123 Main St",
                City = "Orlando",
                State = "Florida",
                PostalCode = "45676",
                EmailAddress = "store1@hatts.com",
                Latitude = 21,
                Longitude = 66 },

               new Store { StoreNumber = "4",
                PhoneNumber = "555-5555",
                StreetAddress = "123 Main St",
                City = "Orlando",
                State = "Florida",
                PostalCode = "45676",
                EmailAddress = "store1@hatts.com",
                Latitude = 22,
                Longitude = 33 }
            };
        }

       List<Store> StoreList { get; set; }

    }
}
