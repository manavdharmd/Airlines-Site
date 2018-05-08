using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service_Layer;
public partial class Login : System.Web.UI.Page
{

    protected void login_bbtn_Click(object sender, EventArgs e)
    {
        AirLineServices als = new AirLineServices();

        if (als.ValidateUser(name_tb.Text,
             pwd_tb.Text))
        {
            Session["Id"] = name_tb.Text;
            Response.Redirect("http://localhost:12635/SearchFlight.aspx");
        }
        
    }
}