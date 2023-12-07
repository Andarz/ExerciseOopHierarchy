using ExerciseOopHierarchy;

public class MainCourseMenuItem : MenuItem
{
    private string _name;
    private string _description;
    private decimal _price;

    public MainCourseMenuItem(string name, string description, decimal price) : base(name, description, price)
    {
    }

    public override string ToString()
    {
        return $"Main Course: {base.ToString()}";
    }
}