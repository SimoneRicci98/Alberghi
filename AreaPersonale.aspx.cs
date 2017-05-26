using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class AreaPersonale : System.Web.UI.Page
{
    dbHelper help = new dbHelper("alberghi.accdb");
    OleDbDataReader rs;
    protected void Page_Load(object sender, EventArgs e)
    {
        tabella();
    }
    public void tabella()
    {
        help.connetti();
        help.assegnaComando("SELECT * " +
            "FROM Prenotazioni,Hotel "
            + "WHERE Cod_Utente = " + Session["Utente"].ToString()+
            " AND ID_hotel = Cod_Albergo");
        rs = help.estraiDati();
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[6]
           {new DataColumn("NomeHotel"),
            new DataColumn("DataArrivo"),
            new DataColumn("DataPartenza"),
            new DataColumn("NumPersone"),
            new DataColumn("Costo"),
            new DataColumn("Messaggio")});
        while (rs.Read())
        {
            dt.Rows.Add(rs["Nome"], rs["Arrivo"], rs["Partenza"], rs["NumPersone"], rs["Costo"], rs["Messaggio"]);
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();
        help.disconnetti();
    }
}