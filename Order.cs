using ExerciseOopHierarchy;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    private List<MenuItem> _items = new List<MenuItem>();


    public void AddItem(MenuItem item)
    {
        this._items.Add(item);
    }

    public decimal GetTotal()
    {
        return _items.Sum(x => x.Price);
    }

    public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly();
}