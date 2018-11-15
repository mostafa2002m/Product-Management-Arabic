using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using PRODUCTS_MANAGEMENT.BL;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddPharmacy : Form
    {
        public frm_AddPharmacy()
        {
            InitializeComponent();
            PharmacyInfo();
        }

        private void PharmacyInfo()
        {
            try
            {
                DataTable dt = cls_PharmacyInfo.stp_Get_PharmacyInfo();
                if (dt.Rows.Count > 0)
                {
                    txtId.Text = dt.Rows[0][0].ToString();
                    txtName.Text = dt.Rows[0][1].ToString();
                    txtOwner.Text = dt.Rows[0][2].ToString();
                    txtAddress.Text = dt.Rows[0][3].ToString();
                    txtPhone.Text = dt.Rows[0][4].ToString();
                    txtMobile.Text = dt.Rows[0][5].ToString();
                    txtRCN.Text = dt.Rows[0][6].ToString();
                    txtBankAcount.Text = dt.Rows[0][7].ToString();
                    txtMail.Text = dt.Rows[0][8].ToString();
                    byte[] Arr = (byte[])dt.Rows[0][9];
                    MemoryStream ms = new MemoryStream(Arr);
                    picLogo.Image = Image.FromStream(ms);
                    btnSave.Text = "حفظ التعديلات";
                }
                else
                {
                    txtId.Text = cls_PharmacyInfo.stp_Get_Last_Pharmacy_Id().Rows[0][0].ToString();
                    btnSave.Text = "حفظ";
                }                    
               
            }
            catch (Exception)
            {

                MessageBox.Show("لا يوجد بيانات مسجله");
            }
        }
        
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                // to upload the image file
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All Files|*.*|jpg|*.jpg|Bmp|*.bmp|ico|*.ico|Tiff|*.Tiff|png|*.png";
                //ofd.ShowDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picLogo.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
                // to save the image byte
                MemoryStream ms = new MemoryStream();
                picLogo.Image.Save(ms, picLogo.Image.RawFormat);
                byte[] arr = ms.ToArray();

                
                DataTable dt = cls_PharmacyInfo.stp_Get_PharmacyInfo();
                if (dt.Rows.Count == 0)
                {
                    cls_PharmacyInfo.stp_Manipulate_PharmacyInfo('a', Convert.ToInt32(txtId.Text), txtName.Text, txtOwner.Text,
                        txtAddress.Text, txtPhone.Text, txtMobile.Text, txtRCN.Text, txtBankAcount.Text, txtMail.Text, arr);
                    MessageBox.Show("تم اضافة بيانات الصيدلية بنجاح");
                    /// تنبيه لاضافة منتج جديد
                }
                else
                {
                    cls_PharmacyInfo.stp_Manipulate_PharmacyInfo('u', Convert.ToInt32(txtId.Text), txtName.Text, txtOwner.Text,
                       txtAddress.Text, txtPhone.Text, txtMobile.Text, txtRCN.Text, txtBankAcount.Text, txtMail.Text, arr);
                    MessageBox.Show("تم تعديل بيانات الصيدلية بنجاح");
                    /// تنبيه لاضافة منتج جديد
                }
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeColour(object sender, EventArgs e)
        {
            Button bColour = (Button)sender;
            bColour.BackColor = Color.LightSteelBlue;
        }

        private void ColourChange(object sender, EventArgs e)
        {
            Button bColour = (Button)sender;
            bColour.BackColor = Color.FromKnownColor(KnownColor.Control);
        }
    }
}
