﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

public partial class example04a : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // instantiates a new List object
        List<string> myFriends = new List<String>();

        // Use the method Add to add new elements to the list
        myFriends.Add("Reno");
        myFriends.Add("Lisa");
        myFriends.Add("Michael");
        myFriends.Add("Susan");
        myFriends.Add("Ruben");

        string s = "";

        for (int i = 0; i < myFriends.Count; i++)
        {
            s += myFriends[i] + "<br />";
        }

        ltrMyFriends.Text = s;


    }
}