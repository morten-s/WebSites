using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exercise_02 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        MusicCD myCD = new MusicCD("The Beatles", "Revolver (Remastered)", 128.00M, 2009);
        myCD.Label = "EMI";
        myCD.ImageURL = "images/revolver.jpg";
        ltrProductInfo.Text += myCD.GetHTML();

   

    }
}