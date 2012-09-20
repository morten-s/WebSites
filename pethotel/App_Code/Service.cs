using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Service
/// </summary>
public class Service
{
    // create dictionary collection for prices, and define property to get the Dictionary 
    Dictionary<string, int> prices = new Dictionary<string, int>();
    public Dictionary<string, int> Prices { get { return prices; } }
    // create List with Pets, and define property to get the List  
    List<Pet> pets = new List<Pet>();
    public List<Pet> Pets { get { return pets; } }
    
    //Kunde liste
    List<Customer> customer = new List<Customer>();
    public List<Customer> Customer { get { return customer; } }

    public void StartUp()  
    { 
      // add prices to the dictionary, prices 
      prices.Add("Dog", 120); 
      prices.Add("Cat", 60); 
      prices.Add("Snake", 40); 
      prices.Add("Guinea pig", 20); 
      prices.Add("Canary", 15); 

    // create customers 
    Customer c1 = new Customer(1001, "Susan", "Peterson", "Borgergade 45", "8000", "Aarhus", "supe@xmail.dk", "211a212121"); 
      Customer c2 = new Customer(1002, "Brian", "Smith", "Allegade 108", "8000", "Aarhus", "brsm@xmail.dk", "45454545");

        //opret Employees
      Employee e1 = new Employee("Gitte", "Svendsen", "GIT", "234234234");
      Employee e2 = new Employee("Mads", "Juul", "MUL", "911112112");

  
      Pet p1 = new Pet("Dog", "Hamlet", new DateTime(2011, 9, 2),  
                       new DateTime(2011,9,20), c1, e1); 
      Pet p2 = new Pet("Dog", "Samson", new DateTime(2011, 9, 14),  
                       new DateTime(2011, 9, 21), c1, e1); 
      Pet p3 = new Pet("Cat", "Darla", new DateTime(2011, 9, 7),  
                       new DateTime(2011, 9, 10), c2, e2); 
      // add Pets to list of Pet, pets 
      pets.Add(p1); 
      pets.Add(p2); 
      pets.Add(p3);

        // add customers to list
      customer.Add(c1);
      customer.Add(c2);

      
    }
}