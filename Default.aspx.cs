using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbDataReader rs;
        Random rnd = new Random();
        dbHelper help = new dbHelper("alberghi.accdb");
        help.connetti();
        help.assegnaComando("SELECT MAX(ID_Luogo) AS massimo FROM Luoghi");
        rs = help.estraiDati();
        rs.Read();
        int max = int.Parse(rs["massimo"].ToString());
        help.disconnetti();
        int id = rnd.Next(max+1);
        help.connetti();
        help.assegnaComando("SELECT * FROM Luoghi WHERE ID_Luogo = " + id);
        rs = help.estraiDati();
        rs.Read();
        ImageButton1.ImageUrl = rs["Immagine"].ToString();
        lblLuogo.Text = rs["Luogo"].ToString();
        lblDescr.Text = rs["Descrizione"].ToString();
        lblAttr.Text = rs["Attrazioni"].ToString();
        help.disconnetti();

    }
}