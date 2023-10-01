(FoodType, MainIngredient, Seasoning) soup;


Console.WriteLine("Pick a option from menu, then press enter to pick the next one.");




soup.Item1 = (FoodType)Convert.ToInt32(Console.ReadLine());
soup.Item2 = (MainIngredient)Convert.ToInt32(Console.ReadLine());
soup.Item3 = (Seasoning)Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{soup.Item3} {soup.Item2} {soup.Item1}");    


enum FoodType {Soup = 1, Stew, Gumbo}
enum MainIngredient {Mushrooms =1 , Chicken, Carrots, Potatoes }

enum Seasoning {Spicy = 1, Salty, Sweet }