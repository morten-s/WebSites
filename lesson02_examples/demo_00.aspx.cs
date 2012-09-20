using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class demo_00 : System.Web.UI.Page
{

    public class Product {
        
        // private member variable
        private string title;
        // property
        public string Title {
            set { title = value; }
            get { return title; }
        }

        private decimal price;
        public decimal Price {
            set {
                if (value <= 0)
                {
                    throw new Exception("The price is not valid");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {

        Product myNewiPod = new Product();
        myNewiPod.Title = "IPOD NANO MC698";
        //myNewiPod.Price = System.Convert.ToDecimal(1479.00);
        myNewiPod.Price = 1479.00M;

        ltrMyProduct.Text = "My new product: " + myNewiPod.Title;
        ltrMyProduct.Text += "<br />";
        ltrMyProduct.Text += "Cost: " + myNewiPod.Price.ToString();
    }
}