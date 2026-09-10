List<string> goods = ["Mjölk", "Smör"];
List<int> prices = [15, 20];
//Main Loop
while (true)
{   //Check if list is empty
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

    }
    
    Console.ReadLine();
}