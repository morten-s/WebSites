using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class example03 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Product glass = new Product("Wine glass");
        glass.Price = 66.00;
        glass.ImageURL = "grandcru.jpg";

        string html = glass.GetHtml();
        ltrProduct1.Text = html;

        Product bin = new Product("Kitchen Garbage", 425.00, "bin_35l.jpg", "man1");
        ltrProduct2.Text = bin.GetHtml();

        Product knife = new Product("Steelline", 54.50, "st_knife.jpg", "man2");
        ltrProduct3.Text = knife.GetHtml();

        Person nr1 = new Person("Hans", "Hansen", "Nøvlingvej 7", "8900", "Randers");
        nr1.addPhone("2229992");
        nr1.addPhone("13123192");
        nr1.addPhone("21329992");

        ltrPerson1.Text = nr1.DisplayAddress();

        ltrPerson1.Text += nr1.getPhoneNumberList();

        nr1.Birthday = new DateTime(1972,9,2);

        ltrPerson1.Text += nr1.Age();
        
    }

    protected void BtnShowAll_Click(object sender, EventArgs e)
    {
        
    }
}