using System;
using System.Collections.Generic;
using System.Threading;
namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {

            //new instance of city 

            City Nashville = new City("Nashville");

            Building CoffeeHouse = new Building("2827  Adams Drive");
            Building Bank = new Building("2827  Adams Drive");
            Building JailHouse = new Building("2827  Adams Drive");
            Building Hopsital = new Building("2827  Adams Drive");
            Building BrokenBuilding = new Building("2827  Adams Drive");
            Building Gym = new Building("2827  Adams Drive");
            Building Cafe = new Building("2827  Adams Drive");
            Building Bar = new Building("2827  Adams Drive");
            Building Brothel = new Building("2827  Adams Drive");
            //Nine Total Buildings Built
            // Give each building a width, height, and number of stories.

            CoffeeHouse.Width = 1000;
            CoffeeHouse.Depth = 2000;
            CoffeeHouse.Stories = 5;

            Bank.Width = 1000;
            Bank.Depth = 2000;
            Bank.Stories = 5;

            JailHouse.Width = 1000;
            JailHouse.Depth = 2000;
            JailHouse.Stories = 5;

            Hopsital.Width = 1000;
            Hopsital.Depth = 2000;
            Hopsital.Stories = 5;

            BrokenBuilding.Width = 1000;
            BrokenBuilding.Depth = 2000;
            BrokenBuilding.Stories = 5;

            Gym.Width = 1000;
            Gym.Depth = 2000;
            Gym.Stories = 5;

            Cafe.Width = 1000;
            Cafe.Depth = 2000;
            Cafe.Stories = 5;

            Bar.Width = 1000;
            Bar.Depth = 2000;
            Bar.Stories = 5;

            Brothel.Width = 1000;
            Brothel.Depth = 2000;
            Brothel.Stories = 5;

            //Construct the new Buildings with dimensions predefined.
            BrokenBuilding.Construct();
            Bar.Construct();
            Brothel.Construct();
            Cafe.Construct();
            Gym.Construct();
            Hopsital.Construct();
            JailHouse.Construct();
            Bank.Construct();
            CoffeeHouse.Construct();

            //have people purchase your buildings 
            BrokenBuilding.Purchase("Brenda Song");
            Bar.Purchase("Adam Shaffer");
            Brothel.Purchase("Rose Miller");
            Cafe.Purchase("Paul Blart");
            Gym.Purchase("Neagan William");
            Hopsital.Purchase("Stephen Senft");
            JailHouse.Purchase("Billy Madison");
            Bank.Purchase("Fudder nucker");
            CoffeeHouse.Purchase("Jack Jillain");
            Nashville.AddBuilding(BrokenBuilding);
            Nashville.AddBuilding(Bar);
            Nashville.AddBuilding(Brothel);
            Nashville.AddBuilding(Cafe);
            Nashville.AddBuilding(Gym);
            Nashville.AddBuilding(Hopsital);
            Nashville.AddBuilding(JailHouse);
            Nashville.AddBuilding(Bank);
            Nashville.AddBuilding(CoffeeHouse);

              List<Building> BuildingsList = new List<Building>(){
                 BrokenBuilding,Brothel,Bar,Bank,Gym,CoffeeHouse,JailHouse,Hopsital,Cafe
             };

            foreach (Building building in BuildingsList)
            {
                Console.WriteLine(building.buildingAddress());
                Console.WriteLine("----------------------");
                Console.WriteLine($"Designed by: {building.designer()}");
                Console.WriteLine($"Constructed on {building.Constructed()}");
                Console.WriteLine($"Owned by {building.owner()}");
                Console.WriteLine($"{building.Volume} cubic meters of space");

            }

        }
    }
}