using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Product
{
	protected string title;
    public string Title 
    {
        set { title = value; }
        get { return title; }
    }

    protected decimal price;
    public decimal Price
    {
        set { price = value; }
        get { return price; }
    }

    protected string imageURL;
    public string ImageURL
    {
        set { imageURL = value; }
        get { return imageURL; }
    }

    public Product() {}

    public Product(string title, decimal price)
    {
        this.title = title;
        this.price = price;
    }


    public virtual string GetHTML() {
        String s;
        s = "<p>Product title: " + title + "<br />";
        s += "Price: " + price + "<br />";
        s += "<img src=\"" + imageURL + "\" /></p>";
        return s;
    } 

}