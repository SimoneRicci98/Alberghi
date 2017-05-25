using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class login : System.Web.UI.Page
{
    dbHelper help = new dbHelper("Alberghi.accdb");
    OleDbDataReader rs;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {// da controllare

        try
        {
            int app = 0;
            string nome = TextBox1.Text;
            string cognome = TextBox2.Text;
            string email = TxtEmail.Text;
            string psw = TxtPass.Text;
            help.connetti();
            help.assegnaComando("SELECT MAX (ID_Utente) AS massimo FROM Utenti");
            rs = help.estraiDati();
            rs.Read();
            app = int.Parse(rs["massimo"].ToString()) + 1;
            help.disconnetti();

            help.connetti();
            help.assegnaComando("INSERT INTO Utenti VALUES('" + app + "','" + nome + "','" + cognome +"','" + email + "','" + psw + "')");
            help.eseguicomando();
            help.disconnetti();
            Response.Redirect("Default.aspx");
            Session["Utente"] = app.ToString();
        }
        catch
        {
            lblErr.Text = "Compila tutti i campi";
        }
    }
}