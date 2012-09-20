using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
    private string firstname;
    private string lastname;
    private string address;
    private string zipcode;
    private string city;
    private string email;
    private string phone;

    public string Firstname { get { return this.firstname; } set { this.firstname = value; } }
    public string Lastname { get { return this.lastname; } set { this.lastname = value; } }
    public string Address { get { return this.address; } set { this.address = value; } }
    public string Zipcode { get { return this.zipcode; } set { this.zipcode = value; } }
    public string City { get { return this.city; } set { this.city = value; } }
    public string Email { get { return this.email; } set { this.email = value; } }
    public string Phone { 
        get { return this.phone; }
        set {
            //Regex minimum 8 characterer , letter or number, bindestreg
            string pat = "\\w{8,}";
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);
            if (r.Match(value).Success)
            {
                this.phone = value;
            }
            else
            {
                throw new  System.FormatException("invalid phone number");
            }
        }
    }            

    public Person()
    {
    }

    public Person(string firstname, string lastname, string address, string zipcode, string city, string email, string phone)
    {
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.Address = address;
        this.Zipcode = zipcode;
        this.City = city;
        this.Email = email;
        this.Phone = phone;
    }

}
