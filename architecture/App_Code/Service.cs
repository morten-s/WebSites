using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Service
/// </summary>
public class Service
{
    List<Person> persons = new List<Person>();
    public List<Person> Persons 
    {
        get { return persons; }
    }
    
    public void AddPerson(Person person) 
    {
        persons.Add(person);
    }


	public Service()
	{
        Person p = new Person("Richard");
        Car c1 = new Car("BMW 3 Series", 2012, "AF2027X");
        Car c2 = new Car("Ford Fiesta", 2004, "YZ1843Y");
        p.AddCar(c1);
        p.AddCar(c2);

        persons.Add(p);

        p = new Person("Heather");
        c1 = new Car("Fiat 500", 2011, "AB2027Z");
        p.AddCar(c1);

        persons.Add(p);
    }
}