using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class query : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    { 
        dbHelper help = new dbHelper("alberghi.accdb");
    help.connetti();
        help.assegnaComando("ALTER TABLE Prenotazioni ADD Cod_Albergo int");
        help.eseguicomando();
            help.disconnetti();
    }
}