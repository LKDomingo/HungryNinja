class Buffet
{
    public List<Food> Menu;

    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Sushi", 400, false, false),
            new Food("Taco", 500, true, false),
            new Food("Pad Thai", 700, true, true),
            new Food("Burger", 1000, false, false),
            new Food("Ice Cream", 600, false, true),
            new Food("Spaghetti", 400, false, false),
            new Food("BBQ Ribs", 1100, true, true),
        };
    }

    public Food Serve()
    {
        Random rand = new Random();
        Food randFood = Menu[rand.Next(Menu.Count)];
        return randFood;
    }
}
