using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    public class Student
    {
        public string FirstName { get; set; }
        public DateTime LastName { get; set; }

    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        con.Open();
        string checkUser = "select count(*) from UserDat where UserName ='" + TextBoxUNL.Text + "'";
        SqlCommand comm = new SqlCommand(checkUser, con);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        con.Close();
        if (temp == 1)
        {
            con.Open();
            string checkPassQuery = "select password from UserDat where UserName ='" + TextBoxUNL.Text + "'";
            SqlCommand passwordComm = new SqlCommand(checkPassQuery, con);
            string password = passwordComm.ExecuteScalar().ToString().Replace(" ","");
            string checkFnameQuery = "select FirstName from UserDat where UserName ='" + TextBoxUNL.Text + "'";
            SqlCommand fnComm = new SqlCommand(checkFnameQuery, con);
            var fn = fnComm.ExecuteScalar().ToString();
            string checkLnameQuery = "select LastName from UserDat where UserName ='" + TextBoxUNL.Text + "'";
            SqlCommand lnComm = new SqlCommand(checkLnameQuery, con);
            var ln = lnComm.ExecuteScalar().ToString();
           
            if(password == TextBoxPassL.Text )
            {
                Session["New"] = "  "+ fn + " " + ln + "<br/>" + TextBoxUNL.Text;
                Response.Redirect("User.aspx");
            }
            else
            {
                Response.Write("Password is incorrect!");
            }
            
        }
        else
        {
            Response.Write("Username is incorrect!");
        }

    }
    
}