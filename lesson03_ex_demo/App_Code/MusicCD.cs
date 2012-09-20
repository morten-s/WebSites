using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class MusicCD : Product
{
    private string artist;
    public string Artist
    {
        set { artist = value; }
        get { return artist; }
    }

    private string label;
    public string Label
    {
        set { label = value; }
        get { return label; }
    }

    private short released;
    public short Released
    {
        set { released = value; }
        get { return released; }
    }

   
   
    public MusicCD(string artist, string title, decimal price, short released)
        : base(title, price)
    {
        this.artist = artist;
        this.released = released;

        

    }

    public virtual string GetHTML()
    {
        String s;
        s = "<p><strong>Album:</strong> " + title + "<br />";
        s += "<strong>Artist:</strong> " + artist + "<br />";
        s += "<strong>Price:</strong> " + price + "<br />";
        s += "<strong>Publisher:</strong> " + label + " (" + released + ")<br />";
        s += "<img src=\"" + imageURL + "\" /></p>";
        s += "<p><strong>Tracks:</strong><ol>";
        s += "</ol></p>";
        return s;
    }

    public static TimeSpan GetPlayingTime(List<Track> tracks) { 
        TimeSpan ts = TimeSpan.Parse("00:00");

        foreach (Track track in tracks) {
            ts += TimeSpan.Parse("00:" + track.Length); 
        }
        return ts;

    }

  
}