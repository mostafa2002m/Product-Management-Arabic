using System;
using System.Drawing;
using System.Windows.Forms;

namespace PRODUCTS_MANAGEMENT.PL
{
    public partial class frm_AddBackup : Form
    {
       
        public frm_AddBackup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            txtFileName.Text = fd.SelectedPath;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string path = string.Format("{0}\\MyProductDBEn-{1}{2}.bak", txtFileName.Text, DateTime.Now.ToShortDateString().Replace('/', '-'),
                 DateTime.Now.ToLongTimeString().Replace(':', '-'));

                //   txtPath.Text + "\\PharmacyDB" + DateTime.Now.ToShortDateString().Replace('/','-') +
                //DateTime.Now.ToLongTimeString().Replace(':','-')+"bak" ;
                cls_BackRestore.Backup_DB(path);
                MessageBox.Show(@"Process Completed Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

