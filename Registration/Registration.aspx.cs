using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            con.Open();
            string checkUser = "select count(*) from UserDat where UserName ='" + TextBoxUN.Text + "'";
            SqlCommand comm = new SqlCommand(checkUser, con);
            int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Response.Write("User already Exists!");
            }
            con.Close();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Guid newGUID = Guid.NewGuid();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            con.Open();
            string InsertQuery = "insert into UserDat (ID,FIrstName,LastName,UserName,Email,Password,Country) values (@id,@fname,@lname,@uname,@email,@password,@country)";
            SqlCommand comm = new SqlCommand(InsertQuery, con);
            comm.Parameters.AddWithValue("@id", newGUID.ToString());
            comm.Parameters.AddWithValue("@fname", TextBoxFN.Text);
            comm.Parameters.AddWithValue("@lname", TextBoxLN.Text);
            comm.Parameters.AddWithValue("@uname", TextBoxUN.Text);
            comm.Parameters.AddWithValue("@email", TextBoxEmail.Text);
            comm.Parameters.AddWithValue("@password", TextBoxPass.Text);
            comm.Parameters.AddWithValue("@country", DropDownListCountry.SelectedItem.ToString());
            comm.ExecuteNonQuery();
            con.Close();
            
            Response.Redirect("Login.aspx");

        }
        catch (Exception exp)
        {
            Response.Write("Error:" + exp.ToString());
        }
    }
}