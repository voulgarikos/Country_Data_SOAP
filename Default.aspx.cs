using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    com.dneonline.www.Calculator myWS = new com.dneonline.www.Calculator();
    int a, b, apot;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Clear_Click(object sender, EventArgs e)
    {
        tbNumA.Text = "";
        tbNumB.Text = "";
        Label.Text = "";
        
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        
        a = Convert.ToInt32(tbNumA.Text);
        b = Convert.ToInt32(tbNumB.Text);

        apot = myWS.Add(a, b);

        Label.Text = Convert.ToString(apot);

        myWS.Add(a, b);
    }

    protected void BtnSubstr_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tbNumA.Text);
        b = Convert.ToInt32(tbNumB.Text);

        apot = myWS.Subtract(a, b);

        Label.Text = Convert.ToString(apot);

        myWS.Subtract(a, b);
    }

    protected void BtnMulti_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tbNumA.Text);
        b = Convert.ToInt32(tbNumB.Text);

        apot = myWS.Multiply(a, b);

        Label.Text = Convert.ToString(apot);

        myWS.Multiply(a, b);
    }

    protected void BtnDiv_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tbNumA.Text);
        b = Convert.ToInt32(tbNumB.Text);
        if (b != 0)
        {
            apot = myWS.Divide(a, b);

            Label.Text = Convert.ToString(apot);

            myWS.Divide(a, b);
        }
    }
}