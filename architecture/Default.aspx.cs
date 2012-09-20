using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Service service = new Service();

    protected void Page_Load(object sender, EventArgs e)
    {
        List<Person> list = service.Persons;

        string s = "";
        foreach(Person p in list) 
        {
            s += p.Name +"<br/><ul>";
            foreach (Car c in p.Cars)
                s += "<li>" + c.ModelName + "</li>";
            s += "</ul><br/>";
        }

        Literal1.Text = s;
    }
}