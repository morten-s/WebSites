using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class lesson1_exercise_03 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAddition_Click(object sender, EventArgs e)
    {
        double tal1 = Convert.ToDouble(tbNumber1.Text);
        double tal2 = Convert.ToDouble(tbNumber2.Text);
        Double resultat = tal1 + tal2;

        lblResult.Text = resultat.ToString();
    }

    protected void btnSubtraction_Click(object sender, EventArgs e)
    {
        double tal1 = Convert.ToDouble(tbNumber1.Text);
        double tal2 = Convert.ToDouble(tbNumber2.Text);
        Double resultat = tal1 - tal2;

        lblResult.Text = resultat.ToString();
    }
    protected void btnDivision_Click(object sender, EventArgs e)
    {
        double tal1 = Convert.ToDouble(tbNumber1.Text);
        double tal2 = Convert.ToDouble(tbNumber2.Text);
        Double resultat = tal1 / tal2;

        lblResult.Text = resultat.ToString(); 
    }

    protected void btnMultiplication_Click(object sender, EventArgs e)
    {
        double tal1 = Convert.ToDouble(tbNumber1.Text);
        double tal2 = Convert.ToDouble(tbNumber2.Text);
        Double resultat = tal1 * tal2;

        lblResult.Text = resultat.ToString();
    }
}
