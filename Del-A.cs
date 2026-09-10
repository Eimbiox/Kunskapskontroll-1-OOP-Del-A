List<string> goods = [];
List<int> prices = [];
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
    if (int.TryParse(inputGood, out int index))
    {
        //Check if the input number is within bounds of the list, if not show error
        if (index > goods.Count() || index < 0)
        {
            Console.WriteLine($"There are no items at {index}");
            Console.ReadKey();
        }
        else
        {
            //Makes a temp var to show that the item has been removed from the basket
            string tempGood = goods[index -1];
            goods.RemoveAt(index - 1);
            prices.RemoveAt(index - 1);
            Console.WriteLine($"{tempGood} has been removed from the list\nPress any key to continue");
            Console.ReadKey();

        }
    }
    //Check if the string is empty with error
    else if (inputGood == "")
    {
        Console.WriteLine("Please enter in a valid good\nPress any key to continue");
        Console.ReadKey();
    }
    else
    {
        //Ask to enter the price of the good
        Console.WriteLine($"Enter the price of {inputGood}");
        string inputPrice = Console.ReadLine().Trim();
        //Check if the price is a number
        if (int.TryParse(inputPrice, out int price))
        {
            //Check if price is not negative, it can be 0 because its free
           if (price >= 0)
            {
                //Add the items to the lists
                goods.Add(inputGood);
                prices.Add(price);
            }
            else
            {
                Console.WriteLine("Please enter a valid number\nPress any key to continue");
                Console.ReadKey();

            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number\nPress any key to continue");
            Console.ReadKey();
        }
    }   
}
