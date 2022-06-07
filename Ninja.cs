class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
    public bool isFull
    {
        get{
            return calorieIntake > 1200;
        }
    }
    
    // add a constructor
    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }
    // add a public "getter" property called "IsFull"
    // build out the Eat method
    public void Eat(Food item)
    {
        if(!this.isFull)
        {
            this.calorieIntake = this.calorieIntake + item.Calories;
            System.Console.WriteLine(this.calorieIntake);
            this.FoodHistory.Add(item);
            System.Console.WriteLine(item.Name);
            System.Console.WriteLine($"Spicy: {item.IsSpicy}");
            System.Console.WriteLine($"Sweet: {item.IsSweet}");
        } else {
            System.Console.WriteLine("Ninja is too full to eat more!");
        }
    }
}

