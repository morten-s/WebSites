using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class lektion1_rockgrupper : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] bands = { "Beatles", "Rolling Stones", "U2", "Led Zeppelin", "Radiohead" };
        
        /*
                string[] bands = new string[5];
                bands[0] = "Beatles";
                bands[1] = "Rolling Stones";
                bands[2] = "U2";
                bands[3] = "Led Zeppelin";
                bands[4] = "Coldplay";
        */

        

        string sBands = "";
        for (int i = 0; i < bands.Length; i++)
        {
            sBands += "<li>" + bands[i] + "</li>\n";
        }
        lblBands.Text += "<ol>";
        lblBands.Text += sBands;
        lblBands.Text += "</ol>";
    }
}
