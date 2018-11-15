using System;
using System.Net.Mail;
using System.Windows.Forms;


namespace PRODUCTS_MANAGEMENT.PL
{
    class Emails
    {

        public void sendEmail(string z)
        {
            if (String.IsNullOrEmpty(z))
                return;
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(z);
                mail.To.Add("xxx@gmail.com");
                mail.From = new MailAddress("yyy@gmail.com");
                mail.Subject = "sub";

                mail.Body = z;

                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential
                     ("yyy@gmail.com", "pw"); // ***use valid credentials***
                smtp.Port = 587;

                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in sendEmail:" + ex.Message);
            }
        }
    }
}
