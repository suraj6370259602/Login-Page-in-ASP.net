using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Registration_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void btnResetP_Click(object sender, EventArgs e)
    {
        string CS = ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(CS))
        {
            SqlCommand cmd = new SqlCommand("SResetPassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pUsername = new SqlParameter("@UserName", TextBoxResetUN.Text);
            cmd.Parameters.Add(pUsername);

            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (Convert.ToBoolean(read["ReturnCode"]))
                {
                    SendPasswordResetEmail(read["Email"].ToString(), TextBoxResetUN.Text, read["UniqueId"].ToString());
                    lblEmailInstruction.Text = "An email with instruction to reset your password is sent to your registered email.";
                    lblEmailInstruction.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    lblEmailInstruction.ForeColor = System.Drawing.Color.Red;
                    lblEmailInstruction.Text = "User Name is not found!";
                }
            }
        }
    }
    private void SendPasswordResetEmail(string ToEmail, string UserName, string UniqueId)
    {
        MailMessage Mailmessage = new MailMessage("ahmadahsan4574@gmail.com", ToEmail);

        StringBuilder MailBody = new StringBuilder();
        MailBody.Append("Dear " + UserName + ",<br/><br/>");
        MailBody.Append("Please click on following link to reset your password."+"<br/>");
        MailBody.Append("<a href = http://localhost:51231/pracyice/Registration/ChangePassword.aspx?uid=" + UniqueId + "> http://localhost:51231/pracyice/Registration/ChangePassword.aspx?uid=" + UniqueId + "</a>" + "<br/><br/>");
        MailBody.Append("COMSATS CS Department");

        Mailmessage.IsBodyHtml = true;
        Mailmessage.Body = MailBody.ToString();
        Mailmessage.Subject = "Reset Your Password";
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

        smtpClient.Credentials = new System.Net.NetworkCredential()
        {
            UserName = "ahmadahsan4574@gmail.com",
            Password = "window8sp12"
        };

        smtpClient.EnableSsl = true;
        smtpClient.Send(Mailmessage);
    }
}