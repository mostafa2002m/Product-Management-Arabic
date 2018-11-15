using System;
using System.Drawing;
using System.Windows.Forms;
namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddRestore : Form
    {

        public frm_AddRestore()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

            try
            {
                string path = txtFileName.Text;
                cls_BackRestore.Restore_DB(path);
                MessageBox.Show(@"استعادة النسخة الاحتياطية بنجاح");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = ofd.FileName;
            }
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