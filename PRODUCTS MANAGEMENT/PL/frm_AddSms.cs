using PRODUCTS_MANAGEMENT.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddSms : Form
    {
        public frm_AddSms()
        {
            InitializeComponent();
           
           

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //using (System.Net.WebClient client = new System.Net.WebClient())
            //{
            //    try
            //    {
            //        string url = " http://smsc.vianett.no/v3/send.ashx?" +
            //            "src=" + txtPhoneNumber.Text + "&" +
            //            "dst=" + txtPhoneNumber.Text + "&" +
            //            "msg=" + System.Web.HttpUtility.UrlEncode(txtmessage.Text,System.Text.Encoding.GetEncoding("ISO-8859-1")) + "" +
            //            "username=" + System.Web.HttpUtility.UrlEncode(txtUserNmae.Text) + "&" +
            //            "password=" + System.Web.HttpUtility.UrlEncode(txtpassword.Text);
            //        string result = client.DownloadString(url);
            //        if (result.Contains("ok"))
            //            MessageBox.Show("Your Message has been Successfully Sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        else
            //            MessageBox.Show("Message Send Failure.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show(ex.Message,"message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}
            //Set parameters
            string username = "	mostafa2002m@gmail.com";
            string password = "garabage";
            string msgsender = "966508218155";
            string destinationaddr = txtPhoneNumber.Text; ;
            string message = txtmessage.Text;
            // Create ViaNettSMS object with username and password
            ViaNettSMS s = new ViaNettSMS(username, password);
            // Declare Result object returned by the SendSMS function
            ViaNettSMS.Result result;
            try
            {
                // Send SMS through HTTP API
                result = s.sendSMS(msgsender, destinationaddr, message);
                // Show Send SMS response
                if (result.Success)
                {
                    MessageBox.Show("Message successfully sent");
                }
                else
                {
                    MessageBox.Show("Received error: " + result.ErrorCode + " " + result.ErrorMessage);
                }
            }
            catch (System.Net.WebException ex)
            {
                //Catch error occurred while connecting to server.
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

