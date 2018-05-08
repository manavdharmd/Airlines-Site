using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service_Layer;
using Common_Layer;
public partial class FlightBooking : System.Web.UI.Page
{
    AirLineServices als = new AirLineServices();
    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.Visible = true;
        MultiView1.ActiveViewIndex = 0;
        Label6.Text = "User Id";
        Label7.Text = "Flight Id";
        Label8.Text = " No. Of BookSeats";
        Label9.Text = "TravelDate";
        Label1.Text = Session["Id"].ToString();
        Label2.Text = Session["Fid"].ToString();
        Label5.Text = Session["Fd"].ToString();
        for (int i = 1; i <= Convert.ToInt32(Session["Seat"]); i++)
        {
            bs_ddl.Items.Add(i.ToString());
        }


    }

    protected void bs_ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["Tc"]= Convert.ToInt32(bs_ddl.SelectedValue) * Convert.ToInt32(Session["Cost"]);
        Session["Bs"] = bs_ddl.SelectedValue;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Brid"] = new Booking(Session["Id"].ToString(),
            (DateTime)Session["Fd"],
            Session["Fid"].ToString(),
            "B",
            Convert.ToInt32(Session["Bs"]),
            float.Parse(Session["Tc"].ToString())
            );
     Session["Bref"]=als.saveBooking((Booking)Session["Brid"]);
        MultiView1.Visible = true;
        MultiView1.ActiveViewIndex = 1;
            Label10.Text = "Passenger Name";
            Label11.Text = "Age";
        Session["Bs"] = (Convert.ToInt32(Session["Bs"])-1);
        Booking b=(Booking)Session["Brid"];
        b.AddPassenger(pn_txt.Text,Convert.ToInt32(age_txt.Text));
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if ((Convert.ToInt32(Session["Bs"])) == 0)
        {
            Response.Redirect("http://localhost:12635/Confirm.aspx");
        }
        else
        {
            MultiView1.Visible = true;
            MultiView1.ActiveViewIndex = 1;
            Session["Bs"] = (Convert.ToInt32(Session["Bs"]) - 1);
            Label10.Text = "Passenger Name";
            Label11.Text = "Age";
            Booking b = (Booking)Session["Brid"];
            b.AddPassenger(pn_txt.Text, Convert.ToInt32(age_txt.Text));
        }
        
    }
}