using System;
using System.Collections.Generic;

namespace FoodRandomizer
{
    class Program
    {
        static void Main()
        {
            FoodRandomizer foodRandomizer = new FoodRandomizer();

            foodRandomizer.DisplayFoodPlaces();

            Console.WriteLine("\nWhich places do you choose (enter numbers separated by commas)?");
            string userInput = Console.ReadLine();

            foodRandomizer.GetChosenPlaces(userInput);

            foodRandomizer.DisplayChosenPlaces();

            string randomlyChosenPlace = foodRandomizer.GetRandomlyChosenPlace();
            Console.WriteLine($"\nRandomly chosen place: {randomlyChosenPlace}");
        }
    }
}