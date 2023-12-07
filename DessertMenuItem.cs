using ExerciseOopHierarchy;

public class DessertMenuItem : MenuItem
{
    private string _name;
    private string _description;
    private decimal _price;

    public DessertMenuItem(string name, string description, decimal price) : base(name, description, price)
    {
    }

    public override string ToString()
    {
        return $"Dessert: {base.ToString()}";
    }
}