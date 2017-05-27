using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Prenota : System.Web.UI.Page
{
    dbHelper help = new dbHelper("alberghi.accdb");
    int prezzo;
    string[] info;
    OleDbDataReader rs;
    protected void Page_Load(object sender, EventArgs e)
    {
        info = (string[])Session["info"];
        string hotel = Session["hotel"].ToString();
        Label2.Text = "Ecco qui disponibili tutte le informazioni relative alla tua prenotazione";
        TimeSpan ts = DateTime.Parse(info[2]) - DateTime.Parse(info[1]);
        int giorni = ts.Days;
        lblDataArrivo.Text = info[1];
        lblDataPartenza.Text = info[2];
        prezzo = Convert.ToInt16(Session["Prezzo"].ToString()) * giorni;
        lblPrezzo.Text = prezzo.ToString();
        lblNome.Text = hotel;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string messaggio = txtMsg.Text;
        help.connetti();
        help.assegnaComando("SELECT MAX (ID_Prenotazione) AS massimo FROM Prenotazioni");
        rs = help.estraiDati();
        rs.Read();
        int app = int.Parse(rs["massimo"].ToString()) + 1;
        help.disconnetti();

        help.connetti();                                     
        help.assegnaComando("INSERT INTO Prenotazioni VALUES("+app+",'" + 
            prezzo + "','" + 
            messaggio + "','" + 
            info[1] + "','" + 
            info[2] + "'," + 
            info[3] + "," + 
            Session["Utente"].ToString() + "," +
            Session["Stanza"].ToString()+")");
        help.eseguicomando();
        help.disconnetti();
        Response.Redirect("Operazionecompletata.aspx");
    }
}