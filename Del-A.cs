List<string> goods = ["Mjölk", "Smör"];
List<int> prices = [15, 20];
//Main Loop
while (true)
{   Console.Clear();
    //Check if list is empty
    if (goods.Count() == 0)
    {
        Console.WriteLine("There is nothing in your basket");
    }
    else
    {   //Prints out the lists
        for (int i = 0; i < goods.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {goods[i]} - {prices[i]} kr");
        }
        //Prints out total price
        int sum = prices.Sum();
        Console.WriteLine($"Total Price: {sum} kr");
    }
    //Ask for the item input and save in variable
    Console.WriteLine("Type the name of the good you want to add: ");
    string inputGood = Console.ReadLine().Trim();
    //Check if item is with letters not numbers
    if (int.TryParse(inputGood, out int temp))
    {
        Console.WriteLine("Please enter in a valid good");
    }
    else
    {
        Console.WriteLine($"Enter the price of {inputGood}");
    }
    Console.ReadLine();
}