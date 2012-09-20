using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Track
{
	
    private string title;
    public string Title 
    {
        get {return title;}
        set {title = value;}
    }

    private string composer;
    public string Composer 
    {
        get {return composer;}
        set {composer = value;}
    }

    private string length;
    public string Length
    {
        get {return length;}
        set {length = value;}
    }
    
    public Track(string title, string length) {
        this.title = title;
        this.length = length;
        composer = "";
    }

    public string GetHTML()
    {
        string s = title;
        if (composer.Length > 0)
        {
            s += " (" + composer + ") ";
        }
        s += " " + length;
        return s;
    }
}