using ExerciseOopHierarchy;
using System;
using System.Collections.Generic;

public class Restaurant
{
    private List<Customer> _customers;
    private List<MenuItem> _menu;

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public List<MenuItem> GetMenuItem(int index)
    {
        if (index >= 0 && index < .Count)
        {
            return [index];
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }
}