using ExerciseOopHierarchy;
using System.Collections.Generic;

public class Customer
{
    private List<Order> _orderHistory;
    public string Name { get; set; }
    public string Email { get; set; }

    public IReadOnlyList<Order> OrderHistory
    {
        get
        {
            return _orderHistory.AsReadOnly();
        }

    }

    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
        _orderHistory = new List<Order>();
    }

    public void AddOrder(Order order)
    {
        _orderHistory.Add(order);
    }
}