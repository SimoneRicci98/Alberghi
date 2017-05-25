using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Drawing;

public partial class VisualizzaHotel : System.Web.UI.Page
{
    dbHelper help = new dbHelper("alberghi.accdb");
        OleDbDataReader rs;
    
    protected void Page_Load(object sender, EventArgs e)
    {/*
        string[] info = (string[])Session["info"];
        help.connetti();
        help.assegnaComando("SELECT * FROM Hotel WHERE Zona = '"+info[0]+"'");
        rs = help.estraiDati();
        
        //metodo semplice e brutto
        GridView1.DataSource = rs;
        GridView1.DataBind();
        help.disconnetti();*/
        tabella();

    }
    protected void g1_RowCommand(Object sender, GridViewCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);
        GridViewRow row = GridView1.Rows[id];
        help.connetti();
        help.assegnaComando("SELECT ID_hotel FROM Hotel WHERE Zona = '"+row.Cells[2].Text+"' AND Indirizzo = '"+row.Cells[3].Text+"'");
        rs = help.estraiDati();
        rs.Read();
        Session["Hotel"] = rs["ID_hotel"].ToString();
        Response.Redirect("Dettagli.aspx");
        help.disconnetti();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    public void tabella()
    {
        string[] info = (string[])Session["info"];
        help.connetti();
        help.assegnaComando("SELECT Nome,Immagine,Zona,Indirizzo "+
            "FROM Hotel "
            +"WHERE Zona = '"+info[0]+"'");
        rs = help.estraiDati();
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[5]
           {new DataColumn("img"),
            new DataColumn("nome"),
            new DataColumn("zona"),
            new DataColumn("ind"),
            new DataColumn("info")});
        while(rs.Read())
        {
            dt.Rows.Add(ResolveUrl(rs["Immagine"].ToString()), rs["Nome"], rs["Zona"], rs["Indirizzo"], "Clicca qui per saperne di più");
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();
        help.disconnetti();

    }
}