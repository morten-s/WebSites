using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class example01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string s = "Apple Macbook Pro";
        string sub = s.Substring(6, 7);
        int pos = s.IndexOf("book");

        lblStatus.Text = "The string is: <strong>" + s + "</strong><br />";
        lblStatus.Text += "Substring(6, 7) of the string is: <strong>" + s.Substring(6, 7) + "</strong><br />";
        lblStatus.Text += "IndexOf(\"book\") of the string is: <strong>" + s.IndexOf("book") + "</strong>";





    }
}