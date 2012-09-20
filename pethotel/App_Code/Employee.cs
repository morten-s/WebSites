using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ansat
/// </summary>
public class Employee : Person
{
    private string initials;

    public string Initials { get { return this.initials; } set { this.initials = value; } }
    List<Pet> pets = new List<Pet>();
    public List<Pet> Pets { get { return pets; } }
    
    public Employee(string firstname, string lastname, string initials, string phone)
	{
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.Initials = initials;
        this.Phone = phone;
    }
}