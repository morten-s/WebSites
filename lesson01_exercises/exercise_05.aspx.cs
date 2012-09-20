using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exercise_05 : System.Web.UI.Page
{

    private int totalSeconds(int hours, int min) {
        int totalSeconds;
        totalSeconds = hours*60*60 + min*60;
        return totalSeconds;
    }

    private int totalSeconds(int hours, int min, int sec)
    {
        int totalSeconds;
        totalSeconds = hours*60*60 + min*60 + sec;
        return totalSeconds;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btCalculate_Click(object sender, EventArgs e)
    {
        if (tbSeconds.Text == "")
        {
            lblTotalMinues.Text = totalSeconds(Convert.ToInt32(tbHours.Text), Convert.ToInt32(tbMinutes.Text)).ToString();
        }
        else
        {
            lblTotalMinues.Text = totalSeconds(Convert.ToInt32(tbHours.Text), Convert.ToInt32(tbMinutes.Text), Convert.ToInt32(tbSeconds.Text)).ToString();
        }
    }
}