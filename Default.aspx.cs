using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string buf = TextBox1.Text;
        changed_text.InnerHtml = buf.ToUpper();
    }
    protected void btnclick_Click(object sender, EventArgs e)
    {
        lblmessage.Text = "How you Doing!";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if(!String.IsNullOrEmpty(txtbox1.Text))
        {
            lbl1.Text = "Welcome, " + Server.HtmlEncode(txtbox1.Text) + ".<br /> The url is " + Server.UrlEncode(Request.Url.ToString());
        }
    }


    protected void Login_Click(object sender, EventArgs e)
    {
        Server.Transfer("Registration.aspx");
    }
}