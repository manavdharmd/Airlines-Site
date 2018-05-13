using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Data_Layer;
using Common_Layer;
using Service_Layer;
public partial class Confirm : System.Web.UI.Page
{
    AirLineServices als = new AirLineServices();
    protected void Page_Load(object sender, EventArgs e)
    {
      Booking b= als.GetBookingDetails(Convert.ToInt32(Session["Bref"]));
        GridView1.DataSource = b.PASSENGERS;
        GridView1.DataBind();
        Session["B"] = b;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Booking b = (Booking)Session["B"];
        b.Cancel(b.REFERNCEID,Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text));
        als.saveBooking(b);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://localhost:12635/Home.aspx");
    }
}