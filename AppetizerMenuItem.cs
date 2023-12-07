using ExerciseOopHierarchy;

public class AppetizerMenuItem : MenuItem
{
    private string _name;
    private string _description;
    private decimal _price;

    public AppetizerMenuItem(string name, string description, decimal price) : base(name, description, price)
    {
    }

    public override string ToString()
    {
        return $"Appetizer: {base.ToString()}";
    }
}