using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Person
{
    protected string name;
    public string Name { 
        get { return name; } 
        set { name = value; } 
    }

    List<Car> cars = new List<Car>();
    public List<Car> Cars { 
        get { return cars; } 
    }

    public Person(string name) { 
        this.name = name; 
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public override string ToString()
    {
        string s = "Person: " + name;
        return s;
    }

}
