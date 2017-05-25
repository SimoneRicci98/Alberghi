using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
public partial class Dettagli : System.Web.UI.Page
{
    dbHelper help = new dbHelper("alberghi.accdb");
    OleDbDataReader rs;

    protected void Page_Load(object sender, EventArgs e)
    {
        string idHotel = Session["Hotel"].ToString();
        help.connetti();
        help.assegnaComando("SELECT * FROM Hotel WHERE ID_Hotel = "+idHotel);
        rs = help.estraiDati();
        rs.Read();
        Image3.ImageUrl = rs["Immagine"].ToString();
        lblPrd.Text = rs["Nome"].ToString();
        lblPrezzo.Text = rs["Indirizzo"].ToString();
        help.disconnetti();
        tabella();
    }

    protected void g1_RowCommand(Object sender, GridViewCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);
        GridViewRow row = GridView1.Rows[id];
        Session["Prezzo"] = row.Cells[4].Text;
        Response.Redirect("Prenota.aspx");
    }
    public void tabella()
    {
        help.connetti();
        help.assegnaComando("SELECT * " +
            "FROM Stanze "
            + "WHERE Cod_hotel = " + Session["Hotel"].ToString());
        rs = help.estraiDati();
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[6]
           {new DataColumn("Cat"),
            new DataColumn("Nome"),
            new DataColumn("Vista"),
            new DataColumn("Nletti"),
            new DataColumn("Prezzo"),
            new DataColumn("Prenota")});
        while (rs.Read())
        {
            dt.Rows.Add(rs["Categoria"], rs["Nome"], rs["Vista"], rs["NumLetti"], rs["PrezzoPerNotte"],"clicca per prenotare");
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();
        help.disconnetti();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void btnAcquista_Click(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}