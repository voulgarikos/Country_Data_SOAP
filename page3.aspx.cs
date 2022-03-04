using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page3 : System.Web.UI.Page
{
    org.oorsprong.CountryInfoService ct = new org.oorsprong.CountryInfoService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack==false)
        {
          
            org.oorsprong.tCountryCodeAndName[] can =  ct.ListOfCountryNamesByName(); // η μτβλ can γεμίζει από τη κλήση της υπηρεσίας ct
            ddplstLand.Items.Add("- Επιλέξτε -");
            for (int i=0; i<can.Length; i++)
            {
                ddplstLand.Items.Add(can[i].sName);  //exei pedia sname kai sisocode
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string strIsoCountry = ct.CountryISOCode(ddplstLand.Text);
        lblIso.Text = strIsoCountry;
        string strCapital = ct.CapitalCity(strIsoCountry);
        lblCapital.Text = strCapital;
        string strImage = ct.CountryFlag(strIsoCountry);
        Image1.ImageUrl = strImage;
        string strPhone = ct.CountryIntPhoneCode(strIsoCountry);
        lblPhone.Text = strPhone;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}