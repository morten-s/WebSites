using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // initialiserkun en gang
        if (!IsPostBack)
        {
            // create a service object 
            Service service = new Service();
            // call the startUp-method which creates objects 
            service.StartUp();

            // serialize service object og gem i sessions var så det kan bruges ved postback
            Session["serviceobj"] = service;
            service = null;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //og vi henter service object som sessions var og cast til Service type
        Service service = (Service)Session["serviceobj"];
        string header = string.Format("<table class=\"pets\"><tr><td>Species</td><td>Name</td><td>Arrival</td><td>Owner</td><td>Phone</td></tr>");
        Literal1.Text = header;
        
        string c0, c1, c2, c3, c4, c5;
        foreach (Pet p in service.Pets)
        {
            string row = string.Format(
                "<tr><td>{0}</td>"
                +"<td>{1}</td>"
                +"<td>{2}</td>"
                +"<td>{3} {4}</td>"
                +"<td>{5}</td></tr>",
                p.Species,
                p.Name,
                p.Startdate.ToString("d"),
                p.Owner.Firstname,
                p.Owner.Lastname,
                p.Owner.Phone
            );
            Literal1.Text += row;
            
            /* Alternativt
            TableRow tRow = new TableRow();
            TableCell tCell = new TableCell();
            tCell.Text = row;
            tRow.Cells.Add(tCell);
            Table1.Rows.Add(tRow);.....*/
        }
        
        Literal1.Text += "</table>";

        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //hent service object som sessions var og cast
        Service service = (Service)Session["serviceobj"];
        
        //lav table header med class attribut
        Literal1.Text = "<table class=\"invoices\">";
        
        string c0, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c12;
        decimal c11;

        foreach (Pet p in service.Pets)
        {
            Literal1.Text += "<tr><td><br>-------------------------------------------------------------<br></td></tr>";

            c0 = p.Species;
            c1 = p.Name;
            c2 = p.Startdate.ToString("d");
            c3 = p.Enddate.ToString("d");
            c4 = (p.Enddate - p.Startdate).Days.ToString();
            c5 = p.Owner.Firstname;
            c6 = p.Owner.Lastname;
            c7 = p.Owner.Address;
            c8 = p.Owner.City;
            c9 = p.Owner.Zipcode;
            c10 = service.Prices[p.Species].ToString();
            c11 = service.Prices[p.Species] * (p.Enddate - p.Startdate).Days;
            c12 = p.RecievedBy.Firstname + " " + p.RecievedBy.Lastname;
            
            //Bruger string format til at formatere tabel konstruktionen + stylesheet

            string row = string.Format( "<tr><td>{5} {6} </td></tr>"+
                                        "<tr><td>{7}</td></tr>"+
                                        "<tr><td>{9} {8}</td></tr>"+
                                        "<tr><td><br>Species: {0}</td></tr>"+
                                        "<tr><td>Name: {1}</td></tr>"+
                                        "<tr><td>Recieved by: {12}</td></tr>"+
                                        "<tr><td>Period: {2} to {3}</td></tr>"+
                                        "<tr><td>Days: {4}</td></tr>"+
                                        "<tr><td>Price: {10} kr. per. day</td></tr>"+
                                        "<tr><td>Total: {11:n} kr.</td></tr>", 
                                        c0, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12);
            Literal1.Text += row;
        }

        Literal1.Text += "</table>";
    }
    
    protected void Button3_Click(object sender, EventArgs e)
    {
        //hent service object som sessions var og cast
        Service service = (Service)Session["serviceobj"];

        //lav table header med class attribut
        Literal1.Text = "<table class=\"invoices\">";

        string c0, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c12;
        decimal c11, invoiceTotal;
        
        //gennemløb customer liste
        foreach (Customer cus in service.Customer)
        {
            Literal1.Text += "<tr><td><br>-------------------------------------------------------------<br></td></tr>";

            string row = string.Format("<tr><td>{0} {1} </td></tr>" +
                                         "<tr><td>{2}</td></tr>" +
                                         "<tr><td>{3} {4}</td></tr>",
                                         cus.Firstname, cus.Lastname, cus.Address, cus.City, cus.Zipcode);
            Literal1.Text += row;
            
            
            invoiceTotal = 0;
            foreach (Pet p in cus.Lodgedpets)
            {
                c0 = p.Species;
                c1 = p.Name;
                c2 = p.Startdate.ToString("d");
                c3 = p.Enddate.ToString("d");
                c4 = (p.Enddate - p.Startdate).Days.ToString();
                c5 = service.Prices[p.Species].ToString();
                c11 = service.Prices[p.Species] * (p.Enddate - p.Startdate).Days;
                c6 = p.RecievedBy.Firstname + " " + p.RecievedBy.Lastname;
                row = string.Format(
                               "<tr><td><br>Species: {0}</td></tr>" +
                               "<tr><td>Name: {1}</td></tr>" +
                               "<tr><td>Recieved by: {6}</td></tr>" +
                               "<tr><td>Period: {2} to {3}</td></tr>" +
                               "<tr><td>Days: {4}</td></tr>" +
                               "<tr><td>Price: {5} kr. per. day</td></tr>" +
                               "<tr><td>Sum: {7:n} kr.</td></tr>",
                               c0, c1, c2, c3, c4, c5, c6, c11);

                invoiceTotal += c11;
                Literal1.Text += row;

            }
            Literal1.Text += string.Format("<tr><td><strong>Total: {0:n} kr.</strong></td></tr>",
                 invoiceTotal);

        }

        Literal1.Text += "</table>";
    }
}