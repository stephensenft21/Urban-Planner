using System;
using System.Collections.Generic;


namespace Planner
{

    class City
    {
        public City(string cityName)
        {
            CityName = cityName;
        }
        public string CityName { get; set; }
        public string Mayor { get; set; }
        public int Established { get; set; }

        public List<Building> BuildingsList = new List<Building>();

        public void AddBuilding(Building buildingToAdd)
        {

            BuildingsList.Add(buildingToAdd);
        }

        public void ShowCityInfo()
        {
            foreach (Building building in BuildingsList)
            {

                Console.WriteLine($"_____________________");
                Console.WriteLine($"City Name: {CityName}");
                Console.WriteLine($"Mayor: {Mayor}");
                Console.WriteLine($"Established in {Established}");
                Console.WriteLine($"");

            }

        }

    }

}

