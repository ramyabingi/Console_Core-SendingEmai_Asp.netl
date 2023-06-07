using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace SendingEmail
{
    public partial class SendingEmails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sbnbtn_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(email.Text.ToString().Trim());
            mail.From = new MailAddress("bingir411@gmail.com","ramyabingi01@gmail.com");
            mail.Subject = "From Amazon";
            mail.Body = "<p>hello Srikanth Adepu<br>How are you..?";
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl =true ;
            smtp.UseDefaultCredentials =false ;
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("bingir411@gmail.com", "imidjyywrhhvsgya");
            smtp.Send(mail);

        }
    }
}