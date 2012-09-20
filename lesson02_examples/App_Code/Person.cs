using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
    private List<string> Phone; 
 
    public string Firstnavn{get; set;}
    public string Lastnavn{get; set;}
    public string Address{get; set;}
    public string Zip{get; set;}
    public string City{get; set;}

    private DateTime birthday;
    public DateTime Birthday
    {
        set
        {
            if ( DateTime.Now.Year - value.Year > 120)
            {
                throw new Exception("Age not accepted");
            }
            else
            {
                birthday = value;
            }
        }
        get { return birthday; }
    }

    public Person(string Firstnavn, string Lastnavn, string Address, string Zip, string City) 
	{
        this.Firstnavn = Firstnavn;
        this.Lastnavn = Lastnavn;
        this.Address = Address;
        this.Zip = Zip;
        this.City = City;
        Phone = new List<string>();
	}

    public string DisplayAddress()
    { 
        string html;
        html = "<h1>Navn: " + Firstnavn + "&nbsp;" + Lastnavn + "</h1>";
        html +="<h3>Address: " + Address + "</h3>";
        html +="<h3>Zip: " + Zip + "</h3>";
        html +="<h3>City: " + City + "</h3>";
        return html;
    }

    public void addPhone(string phone)
    {
        this.Phone.Add(phone);
    }
    
    public string getPhoneNumberList()
    {
        string html;

        html = "<p>" + Firstnavn + "&nbsp;" +Lastnavn + "<br>(";
        html+= String.Join(",", Phone);
        html += ")</p>";
  
        return html;
    }

    public int Age()
    {
        //DateTime.minvalue = 1/1/1 - derfor er age.Year +1
        DateTime age;
        age = DateTime.MinValue + (DateTime.Now - Birthday);
        return (age.Year-1);
    }
}