using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exercise_04 : System.Web.UI.Page
{

    private int totalMinutes(int hours, int min) {
        //int totalMinutes;
        //totalMinutes = hours * 60 + min;
        //return totalMinutes;
        return (hours * 60 + min);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btCalculate_Click(object sender, EventArgs e)
    {
        int tal1 = Convert.ToInt32(tbHours.Text);
        int tal2 = Convert.ToInt32(tbMinutes.Text);

        int result = totalMinutes(tal1, tal2);
        lblTotalMinues.Text = result.ToString();
    }
}