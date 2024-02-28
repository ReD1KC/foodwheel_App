namespace FoodRandomizer;

class FoodRandomizer
{
    private List<string> favoriteFoodPlaces;
    private List<string> chosenPlaces;

    public FoodRandomizer()
    {
        favoriteFoodPlaces = new List<string>
        {
            "Rissss",
            "BarleY",
            "Ulla",
            "Kokoro",
            "Burgass",
            "Kus-T",
            "D_e",
            "24",
            "25"
        };
        chosenPlaces = new List<string>();
    }

    public void DisplayFoodPlaces()
    {
        Console.WriteLine("Available food places:");
        for (int i = 0; i < favoriteFoodPlaces.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {favoriteFoodPlaces[i]}");
        }
    }

    public void GetChosenPlaces(string userInput)
    {
        string[] choices = userInput.Split(',');
        foreach (string choice in choices)
        {
            if (int.TryParse(choice, out int index) && index >= 1 && index <= favoriteFoodPlaces.Count)
            {
                chosenPlaces.Add(favoriteFoodPlaces[index - 1]);
            }
            else
            {
                Console.WriteLine($"Invalid choice: {choice}. Please choose valid numbers.");
            }
        }
    }

    public void DisplayChosenPlaces()
    {
        Console.WriteLine("\nYou have chosen the following places:");
        foreach (string place in chosenPlaces)
        {
            Console.WriteLine(place);
        }
    }

    public string GetRandomlyChosenPlace()
    {
        Random random = new Random();
        int randomIndex = random.Next(chosenPlaces.Count);
        return chosenPlaces[randomIndex];
    }
}