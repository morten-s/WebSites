using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exercise_03 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        MusicCD myCD = new MusicCD("The Beatles", "Revolver (Remastered)", 128.00M, 2009);
        myCD.Label = "EMI";
        myCD.ImageURL = "images/revolver.jpg";
        Track track01 = new Track("Taxman", "2:28");
        track01.Composer = "Harrison";
        myCD.AddTrack(track01);

        Track track02 = new Track("Eleanor Rigby", "2:06");
        track02.Composer = "Lennon, McCartney";
        myCD.AddTrack(track02);
        
        Track track03 = new Track("I'm Only Sleeping", "3:00");
        track03.Composer = "Lennon, McCartney";
        myCD.AddTrack(track03);
        
        Track track04 = new Track("Love You To", "2:59");
        track04.Composer = "Harrison";
        myCD.AddTrack(track04);

        Track track05 = new Track("Here, There And Everywhere", "2:23");
        track05.Composer = "Harrison";
        myCD.AddTrack(track05);


        Track track06 = new Track("Yellow Submarine", "2:38");
        track06.Composer = "Lennon, McCartney";
        myCD.AddTrack(track06);

        Track track07 = new Track("She Said She Said", "2:36");
        track07.Composer = "Lennon, McCartney";
        myCD.AddTrack(track07);

        Track track08 = new Track("Good Day Sunshine", "2:09");
        track08.Composer = "Lennon, McCartney";
        myCD.AddTrack(track08);

        Track track09 = new Track("And Your Bird Can Sing", "2:00");
        track09.Composer = "Lennon, McCartney";
        myCD.AddTrack(track09);

        Track track10 = new Track("For No One", "1:59");
        track10.Composer = "Lennon, McCartney";
        myCD.AddTrack(track10);

        Track track11 = new Track("Doctor Robert", "1:14");
        track11.Composer = "Lennon, McCartney";
        myCD.AddTrack(track11);

        Track track12 = new Track("I Want To Tell You", "2:27");
        track12.Composer = "Harrison";
        myCD.AddTrack(track12);

        Track track13 = new Track("Got To Get You Into My Life", "2:29");
        track13.Composer = "Lennon, McCartney";
        myCD.AddTrack(track13);

        Track track14 = new Track("Tomorrow Newer Knows", "3:01");
        track14.Composer = "Lennon, McCartney";
        myCD.AddTrack(track14);

        ltrProductInfo.Text += myCD.GetHTML();
        ltrProductInfo.Text += "<p><strong>Total playing time: </strong>" + myCD.GetPlayingTime() + "</p>";
    }
}