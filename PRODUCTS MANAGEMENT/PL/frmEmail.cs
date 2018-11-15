using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                

                SmtpClient client = new SmtpClient("smtp.live.com", 587);
                client.Credentials = new System.Net.NetworkCredential(txtUser.Text, txtPass.Text);
                client.EnableSsl = true;

                MailMessage message = new MailMessage(txtUser.Text, txtTo.Text, txtSubject.Text, rtxBody.Text);
                Attachment attach = new Attachment(txtAttachment.Text);
                message.Attachments.Add(attach);
                // message.Attachments.Add(new Attachment(txtAttachment.Text));
                message.IsBodyHtml = false;
                client.Send(message);
                MessageBox.Show(@"لقد تم ارسال البريد", @"تم", MessageBoxButtons.OK);



               // client.Timeout = 10000;
               
               // client.DeliveryMethod = SmtpDeliveryMethod.Network;
               // client.UseDefaultCredentials = false;
                
               // client.Host = "smTP.gmail.com";
               //client.Port = 587;


               MessageBox.Show(@"لقد تم ارسال البريد", @"تم", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void ofdAttachment_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtAttachment.Text = ofdAttachment.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdAttachment.ShowDialog();
        }
    }
}
