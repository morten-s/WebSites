using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _kunde : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string name = "Klaus Petersen";
        DateTime birthDate = Convert.ToDateTime("1972-06-12");
        
        // assign age as literal
        //int age = 39;

        // or make calulation
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;
        if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
        {
            age--;
        }

        lblName.Text = "Name: " + name;
        lblAge.Text = "Age: " + age.ToString() + " years";
        lblBirthdate.Text = "Birthday: " + birthDate.ToLongDateString().ToString();
        
    }


}
