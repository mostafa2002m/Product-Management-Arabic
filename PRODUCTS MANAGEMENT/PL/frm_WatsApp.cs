using System;
using System.Windows.Forms;
using WhatsAppApi;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_WatsApp : Form
    {
        public frm_WatsApp()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                WhatsApp wa = new WhatsApp(txtPhone.Text, txtPass.Text, txtPass.Text, true);
                wa.OnConnectSuccess += () =>
                {
                    txtStatus.Text = "تم الاتصال .....";
                    wa.OnLoginSuccess += (phone, data) =>
                    {
                        txtStatus.Text += "\r\n تم الاتصال .....!";
                        wa.SendMessage(txtTo.Text, txtMessage.Text);
                        txtStatus.Text += "\r\n تم ارسال الرسالة !";
                    };
                    wa.OnLoginFailed += (data) =>
                    {
                        txtStatus.Text += string.Format("\r\n Connection Failed {0}", data);
                    };
                    wa.Login();
                };
                wa.OnConnectFailed += (ex) =>
                {
                    txtStatus.Text += string.Format("\r\n Connect Failed {0}", ex.StackTrace);
                };
                wa.Connect();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
    }
}
