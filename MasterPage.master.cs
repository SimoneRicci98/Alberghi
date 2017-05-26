using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class MasterPage : System.Web.UI.MasterPage
{
    dbHelper help = new dbHelper("Alberghi.accdb");
    OleDbDataReader rs;
    string dataArrivo;
    string dataPartenza;
    protected void Page_Load(object sender, EventArgs e)
    {
        Destinazione.Items.Clear();
        help.connetti();
        help.assegnaComando("SELECT Zona From Hotel");
        rs = help.estraiDati();
        while (rs.Read())
        {
            Destinazione.Items.Add(rs["Zona"].ToString());
        }
        help.disconnetti();

        if (!IsPostBack)
        {
            ViewState["cont"] = 0;
        }
        if (Session["Utente"] != null)
        {
            help.connetti();
            help.assegnaComando("SELECT Nome FROM Utenti WHERE ID_Utente=" + Session["Utente"].ToString());
            rs = help.estraiDati();
            rs.Read();
            lblNome.Text = "Benvenuto " + rs["Nome"].ToString();
            lblPass.Visible = false;
            lblUser.Visible = false;
            TxtEmail.Visible = false;
            TxtPass.Visible = false;
            btnLog.Visible = false;
            btnReg.Visible = false;
            btnOut.Visible = true;
        }
        else
        {
            lblPass.Visible = true;
            lblUser.Visible = true;
            TxtEmail.Visible = true;
            TxtPass.Visible = true;
            btnLog.Visible = true;
            btnReg.Visible = true;
            btnOut.Visible = false;
        }
    }
     

    protected void Destinazione_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["zona"] = Destinazione.SelectedValue;
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
       
    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        { 
            dataArrivo = Calendar1.SelectedDate.ToString();
            dataPartenza = Calendar2.SelectedDate.ToString();
            string destinazione = Destinazione.SelectedValue;
            string[] info = new string[4];
            info[0] = destinazione;
            info[1] = dataArrivo.Substring(0,10);
            info[2] = dataPartenza.Substring(0,10);
            info[3] = TextBox3.Text;
            Session["info"] = info;
            Response.Redirect("VisualizzaHotel.aspx");
            
        }
        catch
        {
            Response.Write("C'è un errore");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {   
            ViewState["cont"] = (int)ViewState["cont"] + 1;
            TextBox3.Text = ViewState["cont"].ToString();   
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if ((int)ViewState["cont"] != 0)
        {
            ViewState["cont"] = (int)ViewState["cont"] - 1;
            TextBox3.Text = ViewState["cont"].ToString();
        }
    }
    protected void btnReg_Click(object sender, EventArgs e)
    {
        Response.Redirect("Reg.aspx");
    }

    protected void btnLog_Click(object sender, EventArgs e)
    {
        string email;
        string password;
        email = TxtEmail.Text;
        password = TxtPass.Text;
        try
        {
            help.connetti();
            help.assegnaComando("SELECT ID_Utente FROM Utenti WHERE Email='" + email + "' AND Password='" + password + "'");
            rs = help.estraiDati();
            rs.Read();
            Session["Utente"] = rs["ID_Utente"].ToString();
            help.disconnetti();
            Response.Redirect("Default.aspx");

        }
        catch
        {
            help.disconnetti();
            Label1.Visible = true;
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["Utente"] = null;
        Response.Redirect("Default.aspx");
    }
}
