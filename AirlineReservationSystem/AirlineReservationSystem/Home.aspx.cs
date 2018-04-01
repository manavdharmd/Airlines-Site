using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service_Layer;
using Common_Layer;
public partial class Home : System.Web.UI.Page
{
    AirLineServices als = new AirLineServices();
    protected void register_bttn_Click(object sender, EventArgs e)
    {
        try
        {
                als.RegisterUser(new User(ui_tb.Text,
                name_tb.Text,
                pwd_tb.Text,
                Convert.ToInt32(age_tb.Text),
                ccn_tb.Text,
                cct_tb.Text,
                Convert.ToInt32(cem_tb.Text),
                Convert.ToInt32(cey_tb.Text)
                ));
        }
        catch (Exception e2)
        {
        }
    }
}