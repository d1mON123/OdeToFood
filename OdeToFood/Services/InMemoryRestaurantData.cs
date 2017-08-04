using OdeToFood.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private static readonly List<Restaurant> Restaurants;

        static InMemoryRestaurantData()
        {
            Restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    Id = 1,
                    Name = "The House of Kobe"
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "LJ`s and the Kat"
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "King`s Contrivance"
                }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return Restaurants;
        }

        public Restaurant Get(int id)
        {
            return Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            newRestaurant.Id = Restaurants.Max(r => r.Id) + 1;
            Restaurants.Add(newRestaurant);
            return newRestaurant;
        }

        public void Commit()
        {
            //nothing
        }
    }
}
