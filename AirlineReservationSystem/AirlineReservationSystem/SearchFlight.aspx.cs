using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service_Layer;
using Common_Layer;
public partial class SearchFlight : System.Web.UI.Page
{
    AirLineServices als = new AirLineServices();
    List<City> lc = new List<City>();
    protected void Page_Load(object sender, EventArgs e)
    {
        lc=als.GetAllCities();
        foreach (City c in lc)
        {
            ddl_dc.Items.Add(c.NAME);
            ddl_ac.Items.Add(c.NAME);
        }

    }

protected void Button1_Click(object sender, EventArgs e)
    {
       List<FlightSchedule> lfs= als.GetFlightsInRoute(ddl_ac.SelectedValue.ToString(), ddl_dc.SelectedValue.ToString());
        GridView1.DataSource = lfs;
        GridView1.DataBind();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["Cost"] = GridView1.SelectedRow.Cells[2].Text;
        Session["Seat"] = GridView1.SelectedRow.Cells[6].Text;
        Session["Fid"]  = GridView1.SelectedRow.Cells[5].Text;
        Session["Fd"]   = GridView1.SelectedRow.Cells[4].Text;
        Response.Redirect("http://localhost:12635/FlightBooking.aspx");        
    }
}