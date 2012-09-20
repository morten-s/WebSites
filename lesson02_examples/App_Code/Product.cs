using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Product
{
    private string manufacturer;
    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    string name; // field
    public string Name // property
    {
        get { return name; }
        set { name = value; }
    }

    double price; // field
    public double Price // property
    {
        get { return price; }
        set { price = value; }
    }

    string imageURL; // field
    public string ImageURL // property
    {
        get { return imageURL; }
        set { imageURL = value; }
    }

    // constructor 1
    public Product(string name)
    {
        this.name = name;
    }

    // constructor 2
    public Product(string name, double price, string imageURL, string manufacturer)
    {
        this.name = name;
        this.price = price;
        this.imageURL = imageURL;
        this.manufacturer = manufacturer;
    }

    // method
    public string GetHtml()
    {
        string html;
        html = "<h1>" + name + "</h1>";
        html += "<h3> Manufacturer: " + manufacturer + "</h3>";
        html += "<h3> Price: " + price.ToString("0.00") + " kr</h3>";
        html += "<img src=\"images/" + imageURL + "\" />";
        return html;
    }

}