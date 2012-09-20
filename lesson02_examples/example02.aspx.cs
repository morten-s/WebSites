using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class example02 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        // create a new TextBox
        TextBox myTextBox = new TextBox();

        // property examples
        myTextBox.Visible = true;   // set
        bool v = myTextBox.Visible; // get
        myTextBox.Width = 400;   // set
        
        myTextBox.Height = 50; // set


        myTextBox.BackColor = Color.Yellow; // set
        Color c = myTextBox.BackColor; // get

        myTextBox.ID = "comment";
        // put some text inside the TextBox
        myTextBox.Text = "What you see is a fully dynamic generated asp:TextBox";

        // methods
        pnlMainContent.Controls.Add(myTextBox);




    }
}