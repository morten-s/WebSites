using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Kunde
/// </summary>
public class Customer : Person
{
    private int customerId;

    public int CustomerId { get { return this.customerId; } set{ this.customerId = value; } }
    
    //tilføjet Liste object til at summere pets i invoice
    List<Pet> lodgedpets = new List<Pet>();
    public List<Pet> Lodgedpets { get { return lodgedpets; } }


    public Customer(int customerId, string firstname, string lastname, string address, string zipcode, string city, string email, string phone)
    {
        this.CustomerId = customerId;
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.Address = address;
        this.Zipcode = zipcode;
        this.City = city;
        this.Email = email;
        this.Phone = phone;
    }
}