using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Pet
/// </summary>
public class Pet
{
    private string species;
    private string name;
    private DateTime startdate;
    private DateTime enddate;
    private Customer owner;
    private Employee recievedBy;

    public string Species { get { return this.species; } set { this.species = value; } }
    public string Name { get { return this.name; } set { this.name = value; } }
    public DateTime Startdate { get { return this.startdate; } set { this.startdate = value; } }
    public DateTime Enddate { get { return this.enddate; } set { this.enddate = value; } }
    public Customer Owner { get { return this.owner; } set { this.owner = value; } }
    public Employee RecievedBy { get { return this.recievedBy; } set { this.recievedBy = value; } }

    public global::Customer Customer
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }

    public global::Employee Employee
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }


	public Pet(string species, string name, DateTime startdate, DateTime enddate, Customer owner, Employee emp)
	{
        this.Species = species;
        this.Name = name;
        this.Startdate = startdate;
        this.Enddate = enddate;
        this.Owner = owner;
        this.RecievedBy = emp;
        
        // tilføj pets til liste hos employee og hos kunde, viser de dyr der bliver passet pt.
        emp.Pets.Add(this);
        owner.Lodgedpets.Add(this);
	}
}